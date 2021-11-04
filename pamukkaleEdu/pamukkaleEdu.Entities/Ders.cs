using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Entities
{
    public class Ders : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }        
        public int? TeorikSure { get; set; }
        public int? PratikSure { get; set; }

        public ICollection<OgrenciDersDetay> OgrenciDetaylari { get; set; }

    }
}

