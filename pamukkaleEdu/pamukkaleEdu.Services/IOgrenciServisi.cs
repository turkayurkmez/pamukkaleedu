using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services
{
   public interface IOgrenciServisi
    {
        Task<IEnumerable<Ogrenci>> OgrencileriGetir();
    }
}
