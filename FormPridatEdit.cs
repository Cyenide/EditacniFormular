using System;
using System.Linq;
using System.Windows.Forms;

namespace EditacniFormular
{
    // formulář sloužící k přidání nové osoby do databáze nebo pro editaci existující osoby
    public partial class FormPridatEdit : Form
    {
        // instance osoby, kterou chceme editovat
        public Osoba Osoba { get; set; }

        public FormPridatEdit(Osoba osoba = null)
        {
            InitializeComponent();
            
            // pokud byla osoba předána v parametru konstruktoru (označena uživatelem v gridu)
            if (osoba != null)
            {
                Text = "Editace záznamu";
                // uložení parametru konstruktoru do vlastnosti, aby byl parametr přístupný v celé třídě a nejen v konstruktoru
                Osoba = osoba;
                // načtení existujících vlastností záznamu do formuláře
                textJmeno.Text = osoba.Jmeno;
                textPrijmeni.Text = osoba.Prijmeni;
                dateTimePickerDatumNarozeni.Value = osoba.DatumNarozeni;
                textTelefon.Text = osoba.Telefon;
                textEmail.Text = osoba.Email;
            }
            // jinak vytvořit novou osobu
            else
            {
                Text = "Nový záznam";
                Osoba = new Osoba();
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            // jmeno a příjmení jsou povinné údaje, z kontaktních údajů musí být vyplněn aspoň jeden
            if (textJmeno.Text.Trim() != "" &&
                textPrijmeni.Text.Trim() != "" &&
                (textTelefon.Text.Trim() != "" || textEmail.Text.Trim() != ""))
            {
                Osoba.Jmeno = textJmeno.Text;
                Osoba.Prijmeni = textPrijmeni.Text;
                Osoba.DatumNarozeni = dateTimePickerDatumNarozeni.Value;
                if (textTelefon.Text.Trim() == "")
                { 
                    Osoba.Telefon = null; 
                }
                else
                {
                    Osoba.Telefon = textTelefon.Text;
                }
                if (textEmail.Text.Trim() == "")
                {
                    Osoba.Email = null;
                }
                else
                {
                    Osoba.Email = textEmail.Text;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                labelPovinneUdaje.Text = "Jméno a příjmení jsou povinné údaje.\n" +
                    "Musí být vyplněn aspoň jeden z kontaktních údajů (telefonní číslo nebo emailová adresa).";
            }
        }

        private void buttonZavrit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPridatEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonUlozit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                buttonZavrit_Click(sender, e);
            }
        }
    }
}
