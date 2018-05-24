using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public abstract class TableItem : ICiz
    {
        public int ID;

        public string Description { get; set; }
        public abstract List<string> Ciz();
        protected List<string> info = new List<string>();
        public TableItem(string Description,int ID)
        {
            this.Description = Description;
            this.ID = ID;
            this.info.Add(this.ID.ToString());
            this.info.Add(this.Description);
            
            
        }
    }
}
