using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje
{
    public class UserStory:TableItem
    {
        public List<Task> TaskList { get; set; }
        public string SonTarih { get; set; }
        public string Name { get; set; }
        private int aitOlduğuTableIdsi;
        public UserStory(string Description,string Tarih,string Name,int ID,int aitOlduguTableIdsi) : base(Description, ID)
        {
            this.SonTarih = Tarih;
            this.Name = Name;
            this.aitOlduğuTableIdsi = aitOlduguTableIdsi;
            this.info.Add(SonTarih);
            this.info.Add(Name);
            TaskList = new List<Task>();
        }

        public override List<string> Ciz()
        {   // UserStory'e ait verileri bir  list içerisinde dönüyoruz.
            return info;
        }
        public Task TaskEkle(string description) // UserStory içerisine yeni eklenen her task'a eşsiz bir ID ataması sağlıyoruz.
        {
            int ID;
            if (TaskList.Count == 0)
                ID = 1;
            else
            {
                Task temp = (Task)this.TaskList[this.TaskList.Count - 1];
                ID = temp.ID + 1;
            }

            Task yeniTask = new Task(description,ID);
            TaskList.Add(yeniTask);
            return yeniTask;
        }
    }
}
