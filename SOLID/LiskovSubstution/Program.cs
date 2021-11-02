using System;

namespace LiskovSubstution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *   Bir base class ve o class'dan türeyen bir başka sınıf birbirlerinin yerine istisnasız kullanılabilmelidir.
             *   
             */
            var sekil = DortgenGetir(5,10);
           // sekil.Alan();
            

            Console.WriteLine(sekil.Alan());


        }

        static IHesaplanabilirAlan DortgenGetir(int a, int? b=null)
        {
            if (!b.HasValue)
            {
                Kare kare = new Kare { Boy = a };
                return kare;
            }
            else
            {
                Dortgen dortgen = new Dortgen { Boy = a, En = b.Value };
                return dortgen;
            }

           
        }
    }

    public interface IHesaplanabilirAlan
    {
        int Alan();
    }
    public class Dortgen : IHesaplanabilirAlan
    {
        protected int en;
        protected int boy;

        public  int En { get => en; set => en = value; }
        public  int Boy { get => boy; set => boy = value; }

        public int Alan()
        {
            return En * Boy;
        }
    }

    public class Kare : IHesaplanabilirAlan
    {
        public  int Boy { get; set; }

        public int Alan()
        {
           return Boy * Boy;
        }
    }
}
