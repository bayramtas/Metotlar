using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManeger
    {
        //naming convention = isimlendirme kodu
        //syntax = yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" OK.Sepete Eklendi : " + urun.Adı);

        }

        public void Ekle2(string urunadı, string acıklama, string fiyat, string stokadeti)
        {
            Console.WriteLine(" OK.Sepete Eklendi : " + urunadı);
        }
