using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EditacniFormular
{
    public partial class FormGrid : Form
    {
        public FormGrid()
        {
            InitializeComponent();

            // subscribe k události, která slouží k vypnutí right-click menu
            gridView1.PopupMenuShowing += GridView1_PopupMenuShowing;
        }

        // deklarace databázového kontextu
        private SubjektContext _dbContext;

        // při načtení hlavního formuláře
        private void FormGrid_Load(object sender, EventArgs e)
        {
            // navázání nového spojení s databází
            _dbContext = new SubjektContext();

            GridLocalizer.Active = new MujGridLocalizer();
            // searchbar v gridView je vždy vidět
            gridView1.OptionsFind.AlwaysVisible = true;
            // placeholder text v prázdném poli searchbaru
            gridView1.OptionsFind.FindNullPrompt = "Zadejte hledaný výraz";

            // přiřazení zdroje dat do gridu (jako kolekci)
            RefreshGrid();
        }


        private void buttonPridatOsobu_Click(object sender, EventArgs e)
        {
            // otevření editačního formuláře
            FormPridatEdit formPridatEdit = new FormPridatEdit();

            // spustí se pouze pokud uživatel zavřel formulář tlačítkem "OK" (v tomto případě buttonUlozit z formuláře pro editaci)
            if (formPridatEdit.ShowDialog() == DialogResult.OK)
            {
                // přidání vytvořené osoby do databáze skrz kontext a uložení
                _dbContext.Subjekty.Add(formPridatEdit.Osoba);
                _dbContext.SaveChanges();

                // znovunačtení dat do gridu, aby reflektovala nově přidaný subjekt
                RefreshGrid();
            }
        }

        private void buttonEditRadek_Click(object sender, EventArgs e)
        {
            // ziskání dat z vybraného řádku a přetypování na objekt typu Osoba
            Osoba vybranaOsoba = gridView1.GetFocusedRow() as Osoba;

            if (vybranaOsoba != null)
            {
                // předání objektu do parametru konstruktoru formuláře
                FormPridatEdit formPridatEdit = new FormPridatEdit(vybranaOsoba);

                // pokud uživatel zavřel formulář tlačítkem "Uložit"
                if (formPridatEdit.ShowDialog() == DialogResult.OK)
                {
                    _dbContext.SaveChanges();
                    RefreshGrid();
                }
            }
        }

        private void buttonVymazatOsobu_Click(object sender, EventArgs e)
        {

            Osoba vybranaOsoba = gridView1.GetFocusedRow() as Osoba;
            if (vybranaOsoba != null)
            {
                // pokud v potvrzovacím okně uživatel klikne na ano
                if (MessageBox.Show($"Chystáte se smazat osobu {vybranaOsoba.Jmeno} {vybranaOsoba.Prijmeni} z databáze. Pokračovat?",
                    "Smazat osobu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // smazání subjektu
                    _dbContext.Subjekty.Remove(vybranaOsoba);
                    _dbContext.SaveChanges();
                    RefreshGrid();
                }
            }
        }

        // při každém načtení dat do gridu (metoda RefreshGrid())
        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            // vybraný sloupec
            var idSloupec = gridView1.Columns["OsobaId"];
            // změna výchozí pozice čísla ve sloupci z prava do leva
            idSloupec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            // změna jména sloupce
            idSloupec.Caption = "Id";

            gridView1.Columns["Jmeno"].Caption = "Jméno";
            gridView1.Columns["Prijmeni"].Caption = "Příjmení";
            gridView1.Columns["DatumNarozeni"].Caption = "Datum narození";
            gridView1.Columns["Telefon"].Caption = "Telefonní číslo";
            gridView1.Columns["Email"].Caption = "Emailová adresa";
        }

        private void GridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            // slouží k vypnutí right-click menu z column headerů
            // cílení na správný typ menu
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column)
            {
                // zakázání menu vyskočit
                e.Allow = false;
            }
            // dlouho jsem se pokoušel přijít na způsob, jak se zbavit podobného popup menu na searchbaru gridView,
            // ale nepovedlo se
        }

        /// <summary>
        /// Načte data do gridu, aby se projevily provedené změny.
        /// </summary>
        private void RefreshGrid()
        {
            // použito několikrát výše, rozhodl jsem se nahradit metodou
            gridControl1.DataSource = _dbContext.Subjekty.ToList();
        }

        private void buttonNapoveda_Click(object sender, EventArgs e)
        {
            FormNapoveda formNapoveda = new FormNapoveda();
            formNapoveda.ShowDialog();
        }

        private void FormGrid_KeyDown(object sender, KeyEventArgs e)
        {
            // nastavení klávesových zkratek pro tlačítka
            if (e.KeyCode == Keys.F1)
            {
                e.SuppressKeyPress = true;
                buttonNapoveda_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                e.SuppressKeyPress = true;
                buttonPridatOsobu_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3)
            {
                e.SuppressKeyPress = true;
                buttonEditRadek_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4)
            {
                e.SuppressKeyPress = true;
                buttonVymazatOsobu_Click(sender, e);
            }
        }
    }
}
