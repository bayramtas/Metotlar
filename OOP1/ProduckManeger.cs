using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProduckManeger
    {

        public  void  Add(Product product)
        {
            Console.WriteLine(product.productname + "eklendi");

        }
        public void Update(Product product) 
        {
            Console.WriteLine(product.productname + "güncellendi");
        }

        public int Topla(int sayı1, int sayı2)
        {
            return sayı1 + sayı2;
        }
        public void Topla2(int sayı1, int sayı2)
        {
            Console.WriteLine(sayı1+sayı2);
        }
    }
}
