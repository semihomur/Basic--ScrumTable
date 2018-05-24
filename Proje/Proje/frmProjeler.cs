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
    public partial class frmProjeler : Form
    {
        public frmProjeler()
        {
            InitializeComponent();
            
        }
        HuddleMain hm;
        private void frmProjeler_Load(object sender, EventArgs e)
        {
            hm = HuddleMain.getInstance();
            TumTableleriGetir();
        }
        private void TumTableleriGetir()
        {   //Form ilk açılışta dgv'ye dt'den tabloları dolduruyor..
            
            SqlConnection baglan = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama; Integrated Security = True");
            
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Tables", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                dgvprojeListesi.Rows.Add();
                Table t = new Table(oku["Musterisi"].ToString(), oku["ProjeAdi"].ToString(), Convert.ToInt32(oku["TableId"]));
                hm.Tables.Add(t);
                List<string> tableInfo = t.Ciz();
                dgvprojeListesi.Rows[hm.Size - 1].Cells[0].Value = tableInfo[2] + ") " + tableInfo[0];
            }
            baglan.Close();
        }
        
        private void btnprojeKayıt_Click(object sender, EventArgs e)
        {
            if(txtMusteri.Text == "" || txtprojeAdi.Text == "")
                MessageBox.Show("Lütfen ilgili alanları doldurduğunuzdan emin olun ");
            else
            {
                Table yeniTable = hm.addTable(txtMusteri.Text, txtprojeAdi.Text);
                dgvprojeListesi.Rows.Add();
                dgvDoldur(yeniTable);
                txtprojeAdi.Text="";
                txtMusteri.Text = "";
            }
            
        }

        private void  dgvDoldur(Table yeniTable)
        {           
            List<string> tableInfo = yeniTable.Ciz();            
            dgvprojeListesi.Rows[hm.Size - 1].Cells[0].Value = tableInfo[2]+ ") "+ tableInfo[0];
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama;Integrated Security = True");
            //Yeni table dgv'ye aktarılırken dt'yede aktarılıyor..
            con.Open();
            SqlCommand komut = new SqlCommand("Insert into Tables(TableId,ProjeAdi,Musterisi) Values ('" + tableInfo[2].ToString() + "','" + tableInfo[0].ToString() + "','" + tableInfo[1].ToString() + "')", con);
            komut.ExecuteNonQuery();
            con.Close();

        }

        private void dgvprojeListesi_DoubleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Table Table = hm.getTable(findCorrectCell(e.RowIndex));
                frmScrum scrum = new frmScrum(Table);
                scrum.Text = Table.Ciz()[0];
                scrum.ShowDialog();
            }
        }

        private string findCorrectCell(int rowNumber)
        {   

            string projeAdiVeID = dgvprojeListesi.Rows[rowNumber].Cells[0].Value.ToString();
            char[] chrProjeAdiVeID = projeAdiVeID.ToCharArray();
            int i = 0;
            string msg = null;
            while (chrProjeAdiVeID[i] != ')')
            {
                msg += chrProjeAdiVeID[i];
                i++;
            }
            return msg;
        }     
        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            
            try
            {
                Table Table = hm.getTable(findCorrectCell(dgvprojeListesi.CurrentCell.RowIndex));
                DialogResult dr = MessageBox.Show(Table.Ciz()[0]+" isimli projeyi silmek istediğinizden emin misiniz ?",
                      "Uyarı", MessageBoxButtons.YesNo);
                switch (dr)
                {   
                    case DialogResult.Yes://İlgili projeye ait verilerin silinmesi
                        SqlConnection baglan = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama;MultipleActiveResultSets = True; Integrated Security = True");
                        baglan.Open();
                        SqlCommand komutTableSil = new SqlCommand("Delete from Tables where TableId=(" + Table.ID + ")", baglan);
                        komutTableSil.ExecuteNonQuery();
                        baglan.Close();
                        baglan.Open();
                        SqlCommand komutUserStorySil = new SqlCommand("Delete from UserStory where TableNo=(" + Table.ID + ")", baglan);
                        komutUserStorySil.ExecuteNonQuery();
                        baglan.Close();
                        baglan.Open();
                        SqlCommand komutTaskSil = new SqlCommand("Delete from Task where TableNo=(" + Table.ID + ")", baglan);
                        komutTaskSil.ExecuteNonQuery();
                        baglan.Close();

                        dgvprojeListesi.Rows.Clear();
                        hm.Tables = new List<IUserStoryEkleyebilir>();
                        TumTableleriGetir();
                        break;
                    case DialogResult.No:
                        break;
                }
                
                
            }catch(NullReferenceException excp)
            {
                MessageBox.Show("Silinecek projeniz bulunmamaktadır !");
            }
     
        }

        
    }
}
