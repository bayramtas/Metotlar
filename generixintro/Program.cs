using System;

namespace generixintro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Mylist<string> isimler = new Mylist<string>();
            isimler.Add("bayram");

            Console.WriteLine(isimler.length);

            isimler.Add("nazlı");
            Console.WriteLine(isimler.length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }

        }
    }
}
