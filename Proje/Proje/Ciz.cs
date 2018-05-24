using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public static class Ciz
    {
        public static List<string> ciz(ICiz cizilebilir)
        {
            return cizilebilir.Ciz();
        }
    }
}
