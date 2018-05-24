using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class HuddleMain
    {
       
        private static HuddleMain instance;
        private HuddleMain()
        {
            Tables = new List<IUserStoryEkleyebilir>();
        }
        

        public int Size
        {
            get { return Tables.Count ; }
            
        }

        public List<IUserStoryEkleyebilir> Tables { get; set; }
        public static HuddleMain getInstance()
        {
            if (instance == null)
                instance = new HuddleMain();

            return instance;
             
        }
        public Table getTable(string id)
        {
            Table wanted = null;
            foreach(Table t in Tables)
            {
                if(t.Ciz()[2]== id.ToString())
                {
                    wanted = t;
                    
                }
            }
           
            return wanted;
        } 
        public Table addTable(string musteri, string projeAdi) 
        { 
            // Yaratılan her bir table nesnesi için eşsiz bir ıd oluşturuyoruz.
            int ID;
            if(Tables.Count == 0)
                ID = 1;
            else
            {
                Table temp =(Table) this.Tables[this.Tables.Count - 1];
                ID = temp.ID + 1;
            }
                
            Table yeniTable = new Table(musteri, projeAdi, ID);
            Tables.Add(yeniTable);
            return yeniTable;
        }

    }
}
