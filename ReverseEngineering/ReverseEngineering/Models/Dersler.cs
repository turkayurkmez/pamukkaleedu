using System;
using System.Collections.Generic;

#nullable disable

namespace ReverseEngineering.Models
{
    public partial class Dersler
    {
        public Dersler()
        {
            OgrencilerDerslers = new HashSet<OgrencilerDersler>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int? TeorikSure { get; set; }
        public int? PratikSure { get; set; }

        public virtual ICollection<OgrencilerDersler> OgrencilerDerslers { get; set; }
    }
}
