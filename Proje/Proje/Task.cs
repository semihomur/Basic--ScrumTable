using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public class Task : TableItem
    {
        public string SonTarih { get; set; }
        public string Kisi { get; set; }
        public int location { get; set; } // Gene task'ın hangi safhada olduğu bilgisini tutuyoruz.    
        public Task(string Description, int ID) : base(Description,ID)
        {
            info = new List<string>();
            info.Add(Description);
            info.Add(ID.ToString());
        }
        public override List<string> Ciz() 
        {
            return info;
        }
    }
}
