using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class TaskTool : UserControl
    {
        public int location = 1; // TaskTool'un hangi panelde durduğunu tutuyoruz. Her yeni eklenen task waiting safhasında başladığı için default = 1
        public TaskTool()
        {
            InitializeComponent();
        }

    }
}
