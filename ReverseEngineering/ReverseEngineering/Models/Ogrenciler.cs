using System;
using System.Collections.Generic;

#nullable disable

namespace ReverseEngineering.Models
{
    public partial class Ogrenciler
    {
        public Ogrenciler()
        {
            OgrencilerDerslers = new HashSet<OgrencilerDersler>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OgrenciNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string Program { get; set; }
        public string Durum { get; set; }
        public DateTime? OlusturulmaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public virtual ICollection<OgrencilerDersler> OgrencilerDerslers { get; set; }
    }
}
