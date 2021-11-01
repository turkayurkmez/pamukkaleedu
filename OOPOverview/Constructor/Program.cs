using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekmek ekmek = new Ekmek(3);
            Console.WriteLine($"{ekmek.Adet} adet {ekmek.Tur} ekmek" );


        }
    }
}
