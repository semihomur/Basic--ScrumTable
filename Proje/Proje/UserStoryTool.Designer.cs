namespace Proje
{
    partial class UserStoryTool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labell = new System.Windows.Forms.Label();
            this.dtTarih = new DevExpress.XtraEditors.DateEdit();
            this.btntaskEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtstoryAdi = new System.Windows.Forms.TextBox();
            this.lblstoryAdı = new System.Windows.Forms.Label();
            this.lblsonTarih = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.pnlNotStarted = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAccTest = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDone = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labell
            // 
            this.labell.AutoSize = true;
            this.labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labell.ForeColor = System.Drawing.Color.White;
            this.labell.Location = new System.Drawing.Point(33, 11);
            this.labell.Name = "labell";
            this.labell.Size = new System.Drawing.Size(28, 17);
            this.labell.TabIndex = 0;
            this.labell.Text = "ID:";
            // 
            // dtTarih
            // 
            this.dtTarih.EditValue = null;
            this.dtTarih.Location = new System.Drawing.Point(99, 62);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Size = new System.Drawing.Size(115, 22);
            this.dtTarih.TabIndex = 2;
            // 
            // btntaskEkle
            // 
            this.btntaskEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntaskEkle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btntaskEkle.Appearance.Options.UseFont = true;
            this.btntaskEkle.Appearance.Options.UseForeColor = true;
            this.btntaskEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btntaskEkle.Location = new System.Drawing.Point(165, 242);
            this.btntaskEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btntaskEkle.Name = "btntaskEkle";
            this.btntaskEkle.Size = new System.Drawing.Size(75, 30);
            this.btntaskEkle.TabIndex = 3;
            this.btntaskEkle.Text = "Task Ekle";
            this.btntaskEkle.Click += new System.EventHandler(this.btntaskEkle_Click);
            // 
            // txtstoryAdi
            // 
            this.txtstoryAdi.Location = new System.Drawing.Point(99, 36);
            this.txtstoryAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstoryAdi.Name = "txtstoryAdi";
            this.txtstoryAdi.Size = new System.Drawing.Size(113, 22);
            this.txtstoryAdi.TabIndex = 5;
            // 
            // lblstoryAdı
            // 
            this.lblstoryAdı.AutoSize = true;
            this.lblstoryAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstoryAdı.ForeColor = System.Drawing.Color.White;
            this.lblstoryAdı.Location = new System.Drawing.Point(3, 36);
            this.lblstoryAdı.Name = "lblstoryAdı";
            this.lblstoryAdı.Size = new System.Drawing.Size(79, 17);
            this.lblstoryAdı.TabIndex = 4;
            this.lblstoryAdı.Text = "Story Adı:";
            // 
            // lblsonTarih
            // 
            this.lblsonTarih.AutoSize = true;
            this.lblsonTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonTarih.ForeColor = System.Drawing.Color.White;
            this.lblsonTarih.Location = new System.Drawing.Point(-3, 64);
            this.lblsonTarih.Name = "lblsonTarih";
            this.lblsonTarih.Size = new System.Drawing.Size(84, 17);
            this.lblsonTarih.TabIndex = 6;
            this.lblsonTarih.Text = "Son Tarih:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(0, 106);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(165, 166);
            this.txtAciklama.TabIndex = 8;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.White;
            this.lblAciklama.Location = new System.Drawing.Point(47, 86);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(72, 17);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama";
            // 
            // pnlNotStarted
            // 
            this.pnlNotStarted.AllowDrop = true;
            this.pnlNotStarted.Location = new System.Drawing.Point(252, 21);
            this.pnlNotStarted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNotStarted.Name = "pnlNotStarted";
            this.pnlNotStarted.Size = new System.Drawing.Size(285, 251);
            this.pnlNotStarted.TabIndex = 9;
            this.pnlNotStarted.DragDrop += new System.Windows.Forms.DragEventHandler(this._DragDrop);
            this.pnlNotStarted.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // pnlInProgress
            // 
            this.pnlInProgress.AllowDrop = true;
            this.pnlInProgress.Location = new System.Drawing.Point(544, 21);
            this.pnlInProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlInProgress.Name = "pnlInProgress";
            this.pnlInProgress.Size = new System.Drawing.Size(285, 251);
            this.pnlInProgress.TabIndex = 10;
            this.pnlInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this._DragDrop);
            this.pnlInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // pnlAccTest
            // 
            this.pnlAccTest.AllowDrop = true;
            this.pnlAccTest.Location = new System.Drawing.Point(836, 21);
            this.pnlAccTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAccTest.Name = "pnlAccTest";
            this.pnlAccTest.Size = new System.Drawing.Size(285, 251);
            this.pnlAccTest.TabIndex = 11;
            this.pnlAccTest.DragDrop += new System.Windows.Forms.DragEventHandler(this._DragDrop);
            this.pnlAccTest.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // pnlDone
            // 
            this.pnlDone.AllowDrop = true;
            this.pnlDone.Location = new System.Drawing.Point(1128, 21);
            this.pnlDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(285, 251);
            this.pnlDone.TabIndex = 12;
            this.pnlDone.DragDrop += new System.Windows.Forms.DragEventHandler(this._DragDrop);
            this.pnlDone.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(539, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 282);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(831, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 282);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1121, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 282);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 282);
            this.label4.TabIndex = 16;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnKaydet.Location = new System.Drawing.Point(165, 208);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 30);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(104, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 18;
            // 
            // UserStoryTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDone);
            this.Controls.Add(this.pnlAccTest);
            this.Controls.Add(this.pnlInProgress);
            this.Controls.Add(this.pnlNotStarted);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblsonTarih);
            this.Controls.Add(this.txtstoryAdi);
            this.Controls.Add(this.lblstoryAdı);
            this.Controls.Add(this.btntaskEkle);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.labell);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserStoryTool";
            this.Size = new System.Drawing.Size(1433, 274);
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labell;
        private System.Windows.Forms.Label lblstoryAdı;
        private System.Windows.Forms.Label lblsonTarih;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.DateEdit dtTarih;
        public System.Windows.Forms.TextBox txtstoryAdi;
        public System.Windows.Forms.TextBox txtAciklama;
        public System.Windows.Forms.Label lblID;
        public DevExpress.XtraEditors.SimpleButton btntaskEkle;
        public DevExpress.XtraEditors.SimpleButton btnKaydet;
        public System.Windows.Forms.FlowLayoutPanel pnlNotStarted;
        public System.Windows.Forms.FlowLayoutPanel pnlInProgress;
        public System.Windows.Forms.FlowLayoutPanel pnlAccTest;
        public System.Windows.Forms.FlowLayoutPanel pnlDone;
    }
}
