using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
  public  class Oyuncu
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool TeroristMi { get; set; }
        public string Sembol { get; set; }
        public int KosmaHizi { get; set; }

        public Silah Silah { get; set; }

        public void SolTiklama()
        {
            Silah.Atak();
        }

    }
}
