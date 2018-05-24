using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerForSplash.Interval = 500;
            timerForSplash.Start();
            
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            pbAcilis.Value += 25;
            if (sayac==4)
            {
                
                frmProjeler projeKayıt = new frmProjeler();    
                projeKayıt.Show();
                timerForSplash.Stop();
                this.Hide();
     
            }

        }

    }
}
