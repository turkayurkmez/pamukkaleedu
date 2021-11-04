using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Entities
{
    [Table("Ogrenciler")]
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

        public ICollection<OgrenciDersDetay> DersDetaylari { get; set; }



    }
}
