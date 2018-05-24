namespace Proje
{
    partial class frmProjeler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjeler));
            this.dgvprojeListesi = new System.Windows.Forms.DataGridView();
            this.ProjeAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtprojeAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtMusteri = new DevExpress.XtraEditors.TextEdit();
            this.btnprojeKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.lblProjeAdi = new System.Windows.Forms.Label();
            this.lblMusterisi = new System.Windows.Forms.Label();
            this.pbSymbol = new System.Windows.Forms.PictureBox();
            this.btnProjeSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprojeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprojeAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvprojeListesi
            // 
            this.dgvprojeListesi.AllowUserToAddRows = false;
            this.dgvprojeListesi.AllowUserToDeleteRows = false;
            this.dgvprojeListesi.AllowUserToOrderColumns = true;
            this.dgvprojeListesi.AllowUserToResizeColumns = false;
            this.dgvprojeListesi.AllowUserToResizeRows = false;
            this.dgvprojeListesi.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprojeListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvprojeListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprojeListesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjeAdı});
            this.dgvprojeListesi.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvprojeListesi.Location = new System.Drawing.Point(-1, -1);
            this.dgvprojeListesi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvprojeListesi.Name = "dgvprojeListesi";
            this.dgvprojeListesi.ReadOnly = true;
            this.dgvprojeListesi.RowHeadersVisible = false;
            this.dgvprojeListesi.RowHeadersWidth = 25;
            this.dgvprojeListesi.RowTemplate.Height = 25;
            this.dgvprojeListesi.RowTemplate.ReadOnly = true;
            this.dgvprojeListesi.Size = new System.Drawing.Size(134, 404);
            this.dgvprojeListesi.TabIndex = 0;
            this.dgvprojeListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprojeListesi_DoubleCellClick);
            // 
            // ProjeAdı
            // 
            this.ProjeAdı.HeaderText = "Proje Adı";
            this.ProjeAdı.Name = "ProjeAdı";
            this.ProjeAdı.ReadOnly = true;
            this.ProjeAdı.Width = 130;
            // 
            // txtprojeAdi
            // 
            this.txtprojeAdi.Location = new System.Drawing.Point(176, 198);
            this.txtprojeAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtprojeAdi.Name = "txtprojeAdi";
            this.txtprojeAdi.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtprojeAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtprojeAdi.Size = new System.Drawing.Size(158, 20);
            this.txtprojeAdi.TabIndex = 1;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(176, 253);
            this.txtMusteri.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMusteri.Properties.Appearance.Options.UseBackColor = true;
            this.txtMusteri.Size = new System.Drawing.Size(158, 20);
            this.txtMusteri.TabIndex = 2;
            // 
            // btnprojeKayıt
            // 
            this.btnprojeKayıt.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnprojeKayıt.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnprojeKayıt.Appearance.Options.UseFont = true;
            this.btnprojeKayıt.Appearance.Options.UseForeColor = true;
            this.btnprojeKayıt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnprojeKayıt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprojeKayıt.ImageOptions.Image")));
            this.btnprojeKayıt.Location = new System.Drawing.Point(176, 290);
            this.btnprojeKayıt.Margin = new System.Windows.Forms.Padding(2);
            this.btnprojeKayıt.Name = "btnprojeKayıt";
            this.btnprojeKayıt.Size = new System.Drawing.Size(158, 46);
            this.btnprojeKayıt.TabIndex = 4;
            this.btnprojeKayıt.Text = "Proje Kaydet";
            this.btnprojeKayıt.Click += new System.EventHandler(this.btnprojeKayıt_Click);
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.AutoSize = true;
            this.lblProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAdi.ForeColor = System.Drawing.Color.Green;
            this.lblProjeAdi.Location = new System.Drawing.Point(223, 178);
            this.lblProjeAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(65, 17);
            this.lblProjeAdi.TabIndex = 5;
            this.lblProjeAdi.Text = "Proje Adı";
            // 
            // lblMusterisi
            // 
            this.lblMusterisi.AutoSize = true;
            this.lblMusterisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusterisi.ForeColor = System.Drawing.Color.Green;
            this.lblMusterisi.Location = new System.Drawing.Point(222, 234);
            this.lblMusterisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMusterisi.Name = "lblMusterisi";
            this.lblMusterisi.Size = new System.Drawing.Size(64, 17);
            this.lblMusterisi.TabIndex = 6;
            this.lblMusterisi.Text = "Müşterisi";
            // 
            // pbSymbol
            // 
            this.pbSymbol.Image = ((System.Drawing.Image)(resources.GetObject("pbSymbol.Image")));
            this.pbSymbol.Location = new System.Drawing.Point(160, 11);
            this.pbSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.pbSymbol.Name = "pbSymbol";
            this.pbSymbol.Size = new System.Drawing.Size(185, 164);
            this.pbSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSymbol.TabIndex = 7;
            this.pbSymbol.TabStop = false;
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnProjeSil.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnProjeSil.Appearance.Options.UseFont = true;
            this.btnProjeSil.Appearance.Options.UseForeColor = true;
            this.btnProjeSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnProjeSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProjeSil.ImageOptions.Image")));
            this.btnProjeSil.Location = new System.Drawing.Point(176, 346);
            this.btnProjeSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(158, 46);
            this.btnProjeSil.TabIndex = 8;
            this.btnProjeSil.Text = "Proje Sil";
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // frmProjeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(371, 403);
            this.Controls.Add(this.btnProjeSil);
            this.Controls.Add(this.pbSymbol);
            this.Controls.Add(this.lblMusterisi);
            this.Controls.Add(this.lblProjeAdi);
            this.Controls.Add(this.btnprojeKayıt);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.txtprojeAdi);
            this.Controls.Add(this.dgvprojeListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmProjeler";
            this.Text = "Huddle";
            this.Load += new System.EventHandler(this.frmProjeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprojeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprojeAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSymbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvprojeListesi;
        private DevExpress.XtraEditors.TextEdit txtprojeAdi;
        private DevExpress.XtraEditors.TextEdit txtMusteri;
        private DevExpress.XtraEditors.SimpleButton btnprojeKayıt;
        private System.Windows.Forms.Label lblProjeAdi;
        private System.Windows.Forms.Label lblMusterisi;
        private System.Windows.Forms.PictureBox pbSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjeAdı;
        private DevExpress.XtraEditors.SimpleButton btnProjeSil;
    }
}