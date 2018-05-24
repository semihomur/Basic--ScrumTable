namespace Proje
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pbHuddleSymbol = new DevExpress.XtraEditors.PictureEdit();
            this.pbAcilis = new System.Windows.Forms.ProgressBar();
            this.timerForSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHuddleSymbol.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHuddleSymbol
            // 
            this.pbHuddleSymbol.EditValue = ((object)(resources.GetObject("pbHuddleSymbol.EditValue")));
            this.pbHuddleSymbol.Location = new System.Drawing.Point(2, 2);
            this.pbHuddleSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.pbHuddleSymbol.Name = "pbHuddleSymbol";
            this.pbHuddleSymbol.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbHuddleSymbol.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pbHuddleSymbol.Size = new System.Drawing.Size(279, 262);
            this.pbHuddleSymbol.TabIndex = 0;
            // 
            // pbAcilis
            // 
            this.pbAcilis.Location = new System.Drawing.Point(2, 261);
            this.pbAcilis.Margin = new System.Windows.Forms.Padding(2);
            this.pbAcilis.Name = "pbAcilis";
            this.pbAcilis.Size = new System.Drawing.Size(279, 41);
            this.pbAcilis.TabIndex = 1;
            // 
            // timerForSplash
            // 
            this.timerForSplash.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(281, 305);
            this.Controls.Add(this.pbAcilis);
            this.Controls.Add(this.pbHuddleSymbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.Text = "Huddle";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHuddleSymbol.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pbHuddleSymbol;
        private System.Windows.Forms.ProgressBar pbAcilis;
        private System.Windows.Forms.Timer timerForSplash;
    }
}

