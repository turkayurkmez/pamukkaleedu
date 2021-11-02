using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Büyük sistemler küçüklere değil; küçükler büyüklere bağlı olmalı.
            ReportGenerator reportGenerator = new ReportGenerator(new TelegramSender());
            reportGenerator.Send();
            //elektrik.Yak(odadakiLambayi)

        }


    }

    public class ReportGenerator
    {
        private readonly ISender sender;

        public ReportGenerator(ISender sender)
        {
            this.sender = sender;
        }
        public void Send()
        {
            
            sender.Send();
        }
    }
    public interface ISender
    {
        void Send();
    }
    public class MailSender:ISender
    {
        public void Send()
        {
            Console.WriteLine("Mail gönderildi");
        }
    }

    public class WhatsappSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp ile gönderildi");
        }
    }
    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram uygulaması ile gönderildi");
        }
    }
}
