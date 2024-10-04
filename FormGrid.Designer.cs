namespace EditacniFormular
{
    partial class FormGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrid));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.buttonPridatOsobu = new DevExpress.XtraEditors.SimpleButton();
            this.buttonVymazatOsobu = new DevExpress.XtraEditors.SimpleButton();
            this.buttonEditRadek = new DevExpress.XtraEditors.SimpleButton();
            this.labelCredit = new DevExpress.XtraEditors.LabelControl();
            this.buttonNapoveda = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1166, 744);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // buttonPridatOsobu
            // 
            this.buttonPridatOsobu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPridatOsobu.Appearance.Options.UseFont = true;
            this.buttonPridatOsobu.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.buttonPridatOsobu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonPridatOsobu.ImageOptions.SvgImage")));
            this.buttonPridatOsobu.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.buttonPridatOsobu.Location = new System.Drawing.Point(12, 12);
            this.buttonPridatOsobu.Name = "buttonPridatOsobu";
            this.buttonPridatOsobu.Size = new System.Drawing.Size(69, 23);
            this.buttonPridatOsobu.TabIndex = 1;
            this.buttonPridatOsobu.TabStop = false;
            this.buttonPridatOsobu.Text = "Nový";
            this.buttonPridatOsobu.ToolTip = "Přidat nový záznam\r\nZkratka: F2";
            this.buttonPridatOsobu.Click += new System.EventHandler(this.buttonPridatOsobu_Click);
            // 
            // buttonVymazatOsobu
            // 
            this.buttonVymazatOsobu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVymazatOsobu.Appearance.Options.UseFont = true;
            this.buttonVymazatOsobu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonVymazatOsobu.ImageOptions.SvgImage")));
            this.buttonVymazatOsobu.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.buttonVymazatOsobu.Location = new System.Drawing.Point(165, 12);
            this.buttonVymazatOsobu.Name = "buttonVymazatOsobu";
            this.buttonVymazatOsobu.Size = new System.Drawing.Size(81, 23);
            this.buttonVymazatOsobu.TabIndex = 3;
            this.buttonVymazatOsobu.TabStop = false;
            this.buttonVymazatOsobu.Text = "Smazat";
            this.buttonVymazatOsobu.ToolTip = "Smazat vybraný záznam\r\nZkratka: F4";
            this.buttonVymazatOsobu.Click += new System.EventHandler(this.buttonVymazatOsobu_Click);
            // 
            // buttonEditRadek
            // 
            this.buttonEditRadek.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditRadek.Appearance.Options.UseFont = true;
            this.buttonEditRadek.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonEditRadek.ImageOptions.SvgImage")));
            this.buttonEditRadek.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.buttonEditRadek.Location = new System.Drawing.Point(87, 12);
            this.buttonEditRadek.Name = "buttonEditRadek";
            this.buttonEditRadek.Size = new System.Drawing.Size(72, 23);
            this.buttonEditRadek.TabIndex = 2;
            this.buttonEditRadek.TabStop = false;
            this.buttonEditRadek.Text = "Upravit";
            this.buttonEditRadek.ToolTip = "Upravit vybraný záznam\r\nZkratka: F3";
            this.buttonEditRadek.Click += new System.EventHandler(this.buttonEditRadek_Click);
            // 
            // labelCredit
            // 
            this.labelCredit.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelCredit.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelCredit.Appearance.Options.UseFont = true;
            this.labelCredit.Appearance.Options.UseForeColor = true;
            this.labelCredit.Location = new System.Drawing.Point(12, 791);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(239, 11);
            this.labelCredit.TabIndex = 5;
            this.labelCredit.Text = "Vytvořil Lukáš Brabenec pro výběrové řízení firmy Inisoft\r\n";
            // 
            // buttonNapoveda
            // 
            this.buttonNapoveda.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNapoveda.Appearance.Options.UseFont = true;
            this.buttonNapoveda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.buttonNapoveda.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonNapoveda.ImageOptions.SvgImage")));
            this.buttonNapoveda.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.buttonNapoveda.Location = new System.Drawing.Point(1090, 12);
            this.buttonNapoveda.Name = "buttonNapoveda";
            this.buttonNapoveda.Size = new System.Drawing.Size(88, 23);
            this.buttonNapoveda.TabIndex = 4;
            this.buttonNapoveda.TabStop = false;
            this.buttonNapoveda.Text = "Nápověda";
            this.buttonNapoveda.ToolTip = "Otevře okno s nápovědou\r\nZkratka: F1";
            this.buttonNapoveda.Click += new System.EventHandler(this.buttonNapoveda_Click);
            // 
            // FormGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1190, 810);
            this.Controls.Add(this.buttonNapoveda);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.buttonEditRadek);
            this.Controls.Add(this.buttonVymazatOsobu);
            this.Controls.Add(this.buttonPridatOsobu);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.Name = "FormGrid";
            this.Text = "Tabulka osob";
            this.Load += new System.EventHandler(this.FormGrid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGrid_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton buttonPridatOsobu;
        private DevExpress.XtraEditors.SimpleButton buttonVymazatOsobu;
        private DevExpress.XtraEditors.SimpleButton buttonEditRadek;
        private DevExpress.XtraEditors.LabelControl labelCredit;
        private DevExpress.XtraEditors.SimpleButton buttonNapoveda;
    }
}

