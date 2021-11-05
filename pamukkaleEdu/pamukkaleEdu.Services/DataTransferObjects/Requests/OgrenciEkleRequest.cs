using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services.DataTransferObjects.Requests
{
   public class OgrenciEkleRequest
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string OgrenciNo { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public string Program { get; set; }
        public string Durum { get; set; }
    }
}
