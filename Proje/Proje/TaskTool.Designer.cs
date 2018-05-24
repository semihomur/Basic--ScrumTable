namespace Proje
{
    partial class TaskTool
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
            this.txttaskAciklama = new System.Windows.Forms.TextBox();
            this.txtKisi = new System.Windows.Forms.TextBox();
            this.dtpsonTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttaskAciklama
            // 
            this.txttaskAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttaskAciklama.Location = new System.Drawing.Point(1, 65);
            this.txttaskAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttaskAciklama.Multiline = true;
            this.txttaskAciklama.Name = "txttaskAciklama";
            this.txttaskAciklama.Size = new System.Drawing.Size(135, 60);
            this.txttaskAciklama.TabIndex = 4;
            // 
            // txtKisi
            // 
            this.txtKisi.Location = new System.Drawing.Point(36, 19);
            this.txtKisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Size = new System.Drawing.Size(99, 22);
            this.txtKisi.TabIndex = 6;
            // 
            // dtpsonTarih
            // 
            this.dtpsonTarih.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpsonTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpsonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpsonTarih.Location = new System.Drawing.Point(36, 41);
            this.dtpsonTarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpsonTarih.Name = "dtpsonTarih";
            this.dtpsonTarih.Size = new System.Drawing.Size(100, 22);
            this.dtpsonTarih.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "ST:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(-3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(39, 17);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "Task";
            // 
            // TaskTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpsonTarih);
            this.Controls.Add(this.txtKisi);
            this.Controls.Add(this.txttaskAciklama);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaskTool";
            this.Size = new System.Drawing.Size(134, 124);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txttaskAciklama;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtKisi;
        public System.Windows.Forms.DateTimePicker dtpsonTarih;
    }
}
