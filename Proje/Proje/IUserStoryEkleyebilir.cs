using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    public interface IUserStoryEkleyebilir
    {
        UserStory UserStoryEkle(string aciklama, string tarih, string adi);
    }
}
