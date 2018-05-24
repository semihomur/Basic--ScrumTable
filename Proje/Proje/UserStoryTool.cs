using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class UserStoryTool : UserControl
    {
        Table table;
        Random r = new Random();
        UserStory userStory;
        public List<TaskTool> TaskToolList = new List<TaskTool>();

        public UserStoryTool(Table table, UserStory userStory)
        {
            this.userStory = userStory;
            this.table = table;
            InitializeComponent();
            this.BackColor = Color.FromArgb(r.Next(10, 256), r.Next(10, 256), r.Next(10, 256));
            // UserStoryTool bileşenimiz yaratılırken hangi ait olduğu tablo ve hangi userStory nesnesini temsil ettiğini belirliyoruz.
            
        }

        private void _MouseDown(object sender, MouseEventArgs e) 
        {
            TaskTool temp = (TaskTool)sender;            
            temp.DoDragDrop(temp.GetHashCode().ToString(),DragDropEffects.All);

        }
        private void _DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = e.AllowedEffect;

            }
            else
                e.Effect = DragDropEffects.None;

        }
        private void _DragDrop(object sender, DragEventArgs e)
        {
            // DoDragDrop methoduna text olarak hashCode vermiştik bu kodun gerçekte hangi TaskTool'a ait olduğunu bulmak için bir method çağırıyoruz.
            // İlgili component bulunduktan sonra sender parametresine göre taskTool'un location property'sini dinamik olarak her drop işleminden sonra
            // değiştiriyoruz. Bu bize task'leri yeniden yazdırırken ilgili panele yazmamızda yardımcı oluyor.
            FlowLayoutPanel temp = (FlowLayoutPanel)sender;
            string text = e.Data.GetData(DataFormats.Text).ToString();
            TaskTool taskTool = findCorrespondingTaskTool(text);
            try
            {
                if (temp == pnlNotStarted)
                {
                    taskTool.location = 1;
                }
                else if (temp == pnlInProgress)
                {
                    taskTool.location = 2;
                }
                else if (temp == pnlAccTest)
                {
                    taskTool.location = 3;
                }
                else
                    taskTool.location = 4;
            }
            catch (NullReferenceException f)
            {
                MessageBox.Show("İlgili taski ait olmadığı User Story'e taşıyamazsınız.");
            }

            if (temp.Controls.Count < 4)
            {
                temp.Controls.Add(taskTool);
            }

        }

        private TaskTool findCorrespondingTaskTool(string text)
        {
            // Drag drop esnasında sürüklenilen TaskTool'un hash code propertysinden faydalanarak ilgili TaskToolu bulup drop yapılacak yere
            //gönderiyoruz.
            TaskTool ours = null;
            foreach (TaskTool taskTool in this.TaskToolList)
            {               
                if (taskTool.GetHashCode().ToString()==text)
                {
                    ours = taskTool;
                    break;
                }
            }
            return ours;
        }
        

        private void btnKaydet_Click(object sender, EventArgs e)
        {  
            userStory = table.UserStoryEkle(txtAciklama.Text, dtTarih.Text, txtstoryAdi.Text);
            DTUserStoryKayit(userStory);//Kaydet butonuna basıldığında DataBase'ye yeni user storyleri kaydetme işlemi..
            this.btnKaydet.Enabled = false;
            this.txtAciklama.Enabled = false;
            this.txtstoryAdi.Enabled = false;
            this.dtTarih.Enabled = false;
            this.btntaskEkle.Enabled = true;
            // Kaydetme işlemi sağlandıktan sonra kontrollerin enabled özelliklerini false yapıp değiştirilmelerini engelliyoruz.
        }
        private void DTUserStoryKayit(UserStory us) 
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama; Integrated Security = True");
            con.Open();
            SqlCommand komut = new SqlCommand("Insert into UserStory(TableNo,UserStoryId,UserStoryName,UserStoryDate,UserStoryDescription) Values ('" + table.ID.ToString() + "','" + us.ID.ToString() + "','" +us.Name.ToString() + "','"+us.SonTarih.ToString()+"','"+us.Description+"')", con);
            komut.ExecuteNonQuery();
            con.Close();
        }
      
        private void btntaskEkle_Click(object sender, EventArgs e)
        {
            
            if (TaskToolList.Count<4) 
            {
                // Ekle butonuna basıldığı anda yeni bir TaskTool componenti yaratıp draq drop desteklemesi için ilgili method atamasını sağlıyoruz.
                TaskTool tt = new TaskTool();
                Task added = userStory.TaskEkle(null);
                tt.MouseDown += _MouseDown;
                tt.Cursor = Cursors.Hand; // componentin üzerine gelindiğinde el simgesinin çıkmasını sağlıyoruz.
                tt.lblID.Text += "#"+added.ID.ToString();
                TaskToolList.Add(tt);
                pnlNotStarted.Controls.Add(tt);
                // yeni eklenen TaskTool'u direk olarak pnlNotStarted 'a ekliyoruz.
            }
        }   
        public void doldurTask() //  Sql üzerinden tasklere ait verileri çekmek için kullanıyoruz.
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama; Integrated Security = True");
            con.Open();
            SqlCommand komutokuma = new SqlCommand("Select *from Task", con);
            SqlDataReader oku = komutokuma.ExecuteReader();
            if (userStory.TaskList.Count == 0) // ilk açılış ise verileri dolduracağız.
            {
                while (oku.Read())
                {
                    if ((Convert.ToInt32(oku["TableNo"]) == table.ID && Convert.ToInt32(oku["UserStoryNo"]) == userStory.ID))
                    {
                        Task t = new Task(oku["TaskDesc"].ToString(), Convert.ToInt32(oku["TaskId"]));
                        t.Kisi = oku["TaskKisi"].ToString();
                        t.SonTarih = oku["TaskSonTarih"].ToString();
                        t.location = Convert.ToInt32(oku["TaskLocation"]);
                        userStory.TaskList.Add(t);
                    }
                }
            }
        }
        public void drawTasks() // Scrum formu yüklenirken task componentlerini çizmek için kullanıyoruz.
        {                   
             foreach(Task task in userStory.TaskList)
             {
                TaskTool taskTool = new TaskTool();
                taskTool.MouseDown += _MouseDown;
                taskTool.Cursor = Cursors.Hand;
                taskTool.txttaskAciklama.Text = task.Description;
                taskTool.txtKisi.Text= task.Kisi;
                taskTool.dtpsonTarih.Text = task.SonTarih;
                taskTool.lblID.Text += "#"+task.ID.ToString(); // ID veriyoruz.
                TaskToolList.Add(taskTool);
                taskTool.location = task.location;
                if (task.location == 1)
                {
                    
                    pnlNotStarted.Controls.Add(taskTool);
                }
                else if (task.location == 2)
                {
                    pnlInProgress.Controls.Add(taskTool);
                }
                else if (task.location == 3)
                {
                    pnlAccTest.Controls.Add(taskTool);
                }
                else
                    pnlDone.Controls.Add(taskTool);



            }                                                   
            
        }
        public void StoreTask() //Scrum formu kapatılırken değiştirilen verileri kaydetmek için kullanıyoruz.
        {
            for(int i=0;i<userStory.TaskList.Count;i++)
            {
                userStory.TaskList[i].SonTarih = this.TaskToolList[i].dtpsonTarih.Text;
                userStory.TaskList[i].Kisi = this.TaskToolList[i].txtKisi.Text;
                userStory.TaskList[i].Description = this.TaskToolList[i].txttaskAciklama.Text; // Tasklari saklama işlemini userStoryTool'a atanmış olan 'us' içine yapıyoruz.
                userStory.TaskList[i].location = this.TaskToolList[i].location;
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-OKSGEAA; Initial Catalog = YazılımSınama; MultipleActiveResultSets = True; Integrated Security = True");
                con.Open();
                SqlCommand komutokuma = new SqlCommand("Select *from Task", con);
                SqlDataReader oku = komutokuma.ExecuteReader();
                
                bool kontrol = false;
                //İlk döngü form kapanıp acıldıgında kontrol
                while(oku.Read())
                {
                    if ((Convert.ToInt32(oku["TableNo"]) == table.ID && Convert.ToInt32(oku["UserStoryNo"]) == userStory.ID && Convert.ToInt32(oku["TaskId"]) == userStory.TaskList[i].ID))
                    {
                        kontrol = true;
                        break;
                    }
                }
                if(!kontrol)
                {
                    SqlCommand komut = new SqlCommand("Insert into Task(TableNo,UserStoryNo,TaskId,TaskDesc,TaskLocation,TaskKisi,TaskSonTarih) Values ('" + table.ID.ToString() + "','" + userStory.ID.ToString() + "','" + this.userStory.TaskList[i].ID + "','" + this.userStory.TaskList[i].Description + "','" + userStory.TaskList[i].location + "','"+userStory.TaskList[i].Kisi+"','"+userStory.TaskList[i].SonTarih+"')", con);
                    komut.ExecuteNonQuery();
                }
                con.Close();
                con.Open();
                SqlCommand komutokuma2 = new SqlCommand("Select *from Task", con);
                SqlDataReader oku2 = komutokuma.ExecuteReader();
                //Kullanıcın ilerleyen safhalarda Task Açıklaması,Task Konumu,Task için görevli olan kişi ve son teslim tarihinde olabilecek değişkiliğe karşı DB'de değiştirilmesine karşın güncelleme..
                while (oku2.Read())
                {
                    if (Convert.ToInt32(oku2["TableNo"]) == table.ID && Convert.ToInt32(oku2["UserStoryNo"]) == userStory.ID && Convert.ToInt32(oku2["TaskId"]) == userStory.TaskList[i].ID)
                    {
                        SqlCommand komutguncelle = new SqlCommand("Update Task set TaskDesc='" + this.TaskToolList[i].txttaskAciklama.Text + "' ,TaskLocation='"+ userStory.TaskList[i].location + "',TaskKisi='"+userStory.TaskList[i].Kisi+"',TaskSonTarih='"+userStory.TaskList[i].SonTarih+"' where TaskId=" + userStory.TaskList[i].ID + " AND UserStoryNo=" + userStory.ID + " AND TableNo=" + table.ID + "", con);
                        komutguncelle.ExecuteNonQuery();

                    }
                }

                con.Close();

            }
        }
    }
}
