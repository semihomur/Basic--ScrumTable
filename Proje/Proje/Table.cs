using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Table : IUserStoryEkleyebilir, ICiz
    {
        public int ID;
        private List<string> info = new List<string>();
        private string Musterisi;
        private string ProjeAdi;
        public List<TableItem> UserStories { get; set; }
        public Table(string Musterisi, string ProjeAdi, int ID)
        {   
            this.Musterisi = Musterisi;
            this.ProjeAdi = ProjeAdi;
            this.ID = ID;
            info.Add(this.ProjeAdi);
            info.Add(this.Musterisi);
            info.Add(ID.ToString());
              
            this.UserStories = new List<TableItem>();
        }
        public bool SearchUserStory(int tabloid,int userstoryid)
        {
            //Formun kapatıldıktan sonra tekrar açıldığında aynı user storyleri DB tarafından tekrardan eklemenin engellenmesi.
            foreach (UserStory item in UserStories)
            {
                if (item.ID ==userstoryid && ID ==tabloid)
                    return false;
            }
            return true;
        }
        

        public UserStory UserStoryEkle(string aciklama,string tarih, string adi)
        {
            // Her yeni eklenen UserStory için eşsiz bir ID generate ediyoruz.
            int userStoryID;
            if (UserStories.Count == 0)
                userStoryID = 1;
            else
            {
                UserStory temp = (UserStory)this.UserStories[this.UserStories.Count - 1];
                userStoryID = temp.ID + 1;
            }

            UserStory yeniUserStory = new UserStory(aciklama, tarih,adi,userStoryID, ID);
            UserStories.Add(yeniUserStory);
            return yeniUserStory;
        }

        public List<string> Ciz()
        {
            return info;
        }
        

        
    }
}
