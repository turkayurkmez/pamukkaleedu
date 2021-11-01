using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu = new Oyuncu { Ad = "turkPower", TeroristMi = false };
            oyuncu.Silah = new AK47();
            //oyuncu.Silah = new Sniper();
            //oyuncu.Silah = new Glock();

            oyuncu.SolTiklama();

        }
    }
}
