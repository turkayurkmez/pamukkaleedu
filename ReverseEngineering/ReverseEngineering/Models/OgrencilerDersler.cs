using System;
using System.Collections.Generic;

#nullable disable

namespace ReverseEngineering.Models
{
    public partial class OgrencilerDersler
    {
        public int DersId { get; set; }
        public int OgrenciId { get; set; }
        public int? Notu { get; set; }

        public virtual Dersler Ders { get; set; }
        public virtual Ogrenciler Ogrenci { get; set; }
    }
}
