using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services.DataTransferObjects.Responses
{
  public  class OgrenciDetayResponse
    {
        public int Id { get; set; }      
        public string Ad { get; set; }       
        public string Soyad { get; set; }      
        public string OgrenciNo { get; set; }
        public DateTime? DogumTarihi { get; set; }

        public string Program { get; set; }
        public string Durum { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public string[] Dersler { get; set; }


    }
}
