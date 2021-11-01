using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Silah
    {
        //Her silahın ................... vardır
        public int VurusGucu { get; set; }
        public int Agirlik { get; set; }
        public virtual void Atak()
        {
            Console.WriteLine("Bıçak ile saldırı...");
        }
    }

    public class AtesliSilah: Silah
    {
        public int MermiSayisi { get; set; }
        public int MaksSarjorSayisi { get; set; }
        public int SarsilmaDegeri { get; set; }

        public void SarjorDegistir()
        {

        }
    }

    public class RamboBicak:Silah
    {

    }

    public class Tufek:AtesliSilah
    {
        public bool DurbunVarMi { get; set; }
        public override void Atak()
        {
            base.Atak();
        }
    }
    public class AK47 : Tufek
    {
        public override void Atak()
        {
            Console.WriteLine("AK47 ateş etti");
        }
    }

    public class Sniper: Tufek
    {
        public override void Atak()
        {
            Console.WriteLine("pusuya yatıldı");
        }
    }

    public class Tabanca:AtesliSilah
    {

    }
    public class Glock:Tabanca
    {

    }
}
