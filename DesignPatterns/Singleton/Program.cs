using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileHelper textFileHelper = TextFileHelper.CreateInstance();
            textFileHelper.Length = 8;

            TextFileHelper textFileHelper1 = TextFileHelper.CreateInstance();
            Console.WriteLine(textFileHelper.Length);
            Console.WriteLine(textFileHelper1.Length);


        }
    }

    

    public class TextFileHelper
    {
        private TextFileHelper()
        {

        }

        private static TextFileHelper existingInstance;
        public static TextFileHelper CreateInstance()
        {
            if (existingInstance == null)
            {
                existingInstance = new TextFileHelper();
            }
            return existingInstance;
        }
        public int Length { get; set; }
        public void Read()
        {

        }
        public void Write()
        {

        }
    }
}
