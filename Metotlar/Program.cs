using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // class oluşturma
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyat = 45;
            urun1.Acıklama = "Amasya Elması";
            urun1.stokadeti = 12;

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyat = 145;
            urun2.Acıklama = "Diyarbakır Karpuzu";
            urun2.stokadeti = 23;

            Urun urun3 = new Urun();
            urun3.Adı = "Fasulye";
            urun3.Fiyat = 65;
            urun3.Acıklama = "Ayşe Kadın";
            urun3.stokadeti = 14;

            // mutlaka boşluk olmalı

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Acıklama);
                Console.WriteLine(urun.stokadeti);
                Console.WriteLine("------------------");
            }



            Console.WriteLine("-----------Metodlar--------");

            // instance = class örnegi oluşturma gibi
            // encapsuletion = kapsülleme

            SepetManeger sepetManeger = new SepetManeger();
            sepetManeger.Ekle(urun1);
            sepetManeger.Ekle(urun2);
            sepetManeger.Ekle(urun3);

            sepetManeger.Ekle2("urunadı", "acıklama", "fiyat", "stokadeti");


        }
    }
}
