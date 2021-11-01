using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class Ekmek
    {
        public string Tur { get; set; }
        public int Adet { get; set; }

       
        public Ekmek(int adet) : this(adet, "Beyaz")
        {          
        }

        public Ekmek(string tur):this(1,tur)
        {           
        }

        public Ekmek(int adet, string tur)
        {
            Tur = tur;
            Adet = adet;
        }


    }
}
