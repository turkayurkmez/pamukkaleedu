using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Benzer amaçlarda yazılan işlevlerin arayüzleri farklı olmalıdır.
             * Bir nesnenin, kullanmadığı bir fonksiyonu, interface'den implemente etmesi durumunda bu ihlal edersiniz.
             */
        }
        //public interface IDuck
        //{
        //    void Fly();
        //    void Swim();
        //}

        //public class FlyingDuck : IDuck
        //{
        //    public void Fly()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void Swim()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}


        public interface IMessage
        {
            public string From { get; set; }
            public string To { get; set; }
            public string Body { get; set; }

        }

        public interface IVideoMessage : IMessage
        {
            public int VideoDuration { get; set; }
            public string VideoFormat { get; set; }
        }

        public interface IImageMessage : IMessage
        {
            public string ImageFormat { get; set; }
        }
        public class TextMessage : IMessage
        {
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }

        public class VideoMessage : IVideoMessage
        {
            public int VideoDuration { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string VideoFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string From { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string To { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
    }
}
