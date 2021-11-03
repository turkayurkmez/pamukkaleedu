using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Entities
{
    public class Ogrenci : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string OgrenciNo { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public string Program { get; set; }
        public string Durum { get; set; }

        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public ICollection<Ders> Dersler { get; set; }



    }
}
