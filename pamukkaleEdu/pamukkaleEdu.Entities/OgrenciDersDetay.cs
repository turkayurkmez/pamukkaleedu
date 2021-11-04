using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Entities
{
   public class OgrenciDersDetay
    {

        public int DersId { get; set; }
        public int OgrenciId { get; set; }

        public int? Notu { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }


    }
}
