using System;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varolan bir objeye yeni özellikler ekleme / varolanı değiştirme amacıyla kullanılır.
            //Örnek: Kahve:
            Stream file = new FileStream("", FileMode.Create);
            Stream memory = new MemoryStream();
            //Stream network = new NetworkStream();
            //Sütlü kahve, kahve ister:
            CryptoStream cryptoStream = new CryptoStream(file, null, CryptoStreamMode.Write);
            //Şekerli sütlü kahve, kahve ister:
            GZipStream gZipStream = new GZipStream(cryptoStream, CompressionLevel.Optimal);


        }


    }

    public interface IMail
    {
        string From { get; set; }
        string To { get; set; }
        public string Subject { get; set; }
    }
    public class SignedMail  //:IMail
    {
        private IMail mail;

        public SignedMail(IMail mail)
        {
            this.mail = mail;
        }
        //public string From { get => mail.From; set => mail.From=value; }
        //public string To { get => mail.To; set => mail.To=value; }
        //public string Subject { get => mail.Subject; set => mail.Subject = value; }

        public void AddSign()
        {
            Console.WriteLine("mail nesnesine imza eklendi");
        }
    }
}
