using System;

namespace AbstractANDInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            DokumanCiktiAl dokumanBileseni = new DokumanCiktiAl();
            dokumanBileseni.CiktiAl(new ExcelDokuman());
            dokumanBileseni.CiktiAl(new WordDokuman());

            ExcelDokuman dokuman = new ExcelDokuman();
            dokuman.CiktiAl();

            PdfDokuman pdfDokuman = new PdfDokuman();
            

          //  dokumanBileseni.CiktiAl(new PdfDokuman());
        }
    }


    public abstract class Dokuman
    {
        public void Kopyala(string nereden, string nereye)
        {
            Console.WriteLine($"{nereden} konumundan {nereye} konumuna kopyalandı" );
        }

        public string Baslik { get; set; }
        public string OlusturanKisi { get; set; }
        public abstract void Kaydet(string nereye);
        
       
            //Excel sadece xxx sunucusuna kaydedilir ve .... 'e bilgi verilir....
            //Word ....... 
            //PDF ......

       
    }

    public interface ICiktiAlinabilir
    {
        void CiktiAl();
    }
    public class PdfDokuman : Dokuman
    {
      

        public override void Kaydet(string nereye)
        {
            throw new NotImplementedException();
        }
    }

    public class ExcelDokuman : Dokuman, ICiktiAlinabilir
    {
        public void CiktiAl()
        {
           
        }

        public override void Kaydet(string nereye)
        {
            throw new NotImplementedException();
        }
    }

    public class WordDokuman : Dokuman, ICiktiAlinabilir
    {
        public void CiktiAl()
        {
          
        }

        //public override void CiktiAl()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Kaydet(string nereye)
        {
            throw new NotImplementedException();
        }
    }
    //Bileşen:
    public class DokumanCiktiAl
    {
        public void CiktiAl(ICiktiAlinabilir ciktiAlinabilir)
        {
            ciktiAlinabilir.CiktiAl();
        }
    }


}
