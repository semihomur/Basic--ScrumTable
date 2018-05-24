using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class frmScrum : Form
    {
        HuddleMain hm = HuddleMain.getInstance();
        Table Table;
        public frmScrum(Table table)
        {
            this.Table = table;
            InitializeComponent();
            this.lblMusteri.Text = Table.Ciz()[1];
            this.lblProjeAdi.Text = Table.Ciz()[0];
            TumUserStoryleriGetir();
            UserStoryCiz();
        }
        private void TumUserStoryleriGetir()
        {   //İlk açılışta dt'den tablelere userstoryler ekleniyor..
            SqlConnection baglan = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama; Integrated Security = True");
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from UserStory", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["TableNo"].ToString() == Table.Ciz()[2].ToString())//İlgili table no'ya ait user storyleri belireme..
                {   if(Table.SearchUserStory(Convert.ToInt32(oku["TableNo"]),Convert.ToInt32(oku["UserStoryId"])))//Daha önce form kapatılıp acıldıgında kayıt eklenıp eklenmedıgını kontrol için..
                       {
                        Table.UserStoryEkle(oku["UserStoryDescription"].ToString(), oku["UserStoryDate"].ToString(), oku["UserStoryName"].ToString());
                       }
                }
            }
            baglan.Close();
        }

        private void UserStoryCiz()
        {

            List<TableItem> tableItems = Table.UserStories;
            foreach (TableItem ti in tableItems.ToList())
            {               
                UserStory item = (UserStory)ti;
                UserStoryTool us = new UserStoryTool(Table,item);
                us.btnKaydet.Enabled = false;
                //UserStory çizilirken önce user story'e ait tasklar doldurulup daha sonra çiziliyor..
                us.doldurTask();
                us.drawTasks();
                us.txtAciklama.Enabled = false;
                us.txtstoryAdi.Enabled = false;
               
                us.dtTarih.Enabled = false;
                us.txtAciklama.Text = item.Ciz()[1];
                us.txtstoryAdi.Text = item.Ciz()[3];
                us.lblID.Text = item.Ciz()[0];
                us.dtTarih.Text = item.Ciz()[2];
                // Özellikleri atanan userStoryTool'u Scrum içerisinde bulunan mainPanel içerisine ekliyoruz.
                mainPanel.Controls.Add(us);
                
                
            }

        }

        private void btnUSEkle_Click(object sender, EventArgs e)
        {
            if(mainPanel.Controls.Count > Table.UserStories.Count +1)
                MessageBox.Show("Lütfen oluşturduğunuz 'User Story' ögelerini kaydedip daha sonra yenisini ekleyiniz ");
            else
            {
                UserStoryTool us = new UserStoryTool(Table,null);
                us.btntaskEkle.Enabled = false;
                mainPanel.Controls.Add(us);
            }
            
        }       

        private void frmScrum_FormClosing(object sender, FormClosingEventArgs e)
        {   //Form kapatılırken son kayıt,güncellemeri DB'e aktarıyoruz.
           for(int i = 0; i < mainPanel.Controls.Count; i++)
           {
                
                UserStoryTool temp = (UserStoryTool)mainPanel.Controls[i];
                if(temp.pnlNotStarted.Controls.Count!=0 || temp.pnlInProgress.Controls.Count != 0|| temp.pnlAccTest.Controls.Count != 0|| temp.pnlDone.Controls.Count != 0)
                {
                    temp.StoreTask();
                }             
           }

        }

    }
}
