namespace EditacniFormular
{
    partial class FormNapoveda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNapoveda));
            this.labelInstrukce = new DevExpress.XtraEditors.LabelControl();
            this.ImageBoxNovy = new DevExpress.XtraEditors.SvgImageBox();
            this.ImageBoxUpravit = new DevExpress.XtraEditors.SvgImageBox();
            this.ImageBoxSmazat = new DevExpress.XtraEditors.SvgImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxNovy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxUpravit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxSmazat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInstrukce
            // 
            this.labelInstrukce.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelInstrukce.Appearance.Options.UseFont = true;
            this.labelInstrukce.Location = new System.Drawing.Point(12, 12);
            this.labelInstrukce.Name = "labelInstrukce";
            this.labelInstrukce.Size = new System.Drawing.Size(697, 216);
            this.labelInstrukce.TabIndex = 0;
            this.labelInstrukce.Text = resources.GetString("labelInstrukce.Text");
            // 
            // ImageBoxNovy
            // 
            this.ImageBoxNovy.Location = new System.Drawing.Point(471, 44);
            this.ImageBoxNovy.Name = "ImageBoxNovy";
            this.ImageBoxNovy.Size = new System.Drawing.Size(28, 22);
            this.ImageBoxNovy.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ImageBoxNovy.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageBoxNovy.SvgImage")));
            this.ImageBoxNovy.TabIndex = 1;
            // 
            // ImageBoxUpravit
            // 
            this.ImageBoxUpravit.Location = new System.Drawing.Point(714, 98);
            this.ImageBoxUpravit.Name = "ImageBoxUpravit";
            this.ImageBoxUpravit.Size = new System.Drawing.Size(28, 22);
            this.ImageBoxUpravit.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ImageBoxUpravit.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageBoxUpravit.SvgImage")));
            this.ImageBoxUpravit.TabIndex = 2;
            // 
            // ImageBoxSmazat
            // 
            this.ImageBoxSmazat.Location = new System.Drawing.Point(653, 154);
            this.ImageBoxSmazat.Name = "ImageBoxSmazat";
            this.ImageBoxSmazat.Size = new System.Drawing.Size(28, 22);
            this.ImageBoxSmazat.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ImageBoxSmazat.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ImageBoxSmazat.SvgImage")));
            this.ImageBoxSmazat.TabIndex = 3;
            // 
            // FormNapoveda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 242);
            this.Controls.Add(this.ImageBoxSmazat);
            this.Controls.Add(this.ImageBoxUpravit);
            this.Controls.Add(this.ImageBoxNovy);
            this.Controls.Add(this.labelInstrukce);
            this.KeyPreview = true;
            this.Name = "FormNapoveda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nápověda";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNapoveda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxNovy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxUpravit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxSmazat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelInstrukce;
        private DevExpress.XtraEditors.SvgImageBox ImageBoxNovy;
        private DevExpress.XtraEditors.SvgImageBox ImageBoxUpravit;
        private DevExpress.XtraEditors.SvgImageBox ImageBoxSmazat;
    }
}