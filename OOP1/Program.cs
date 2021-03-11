using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.productname = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, 
                UnitsInStock = 5, productname = "kalem", UnitPrice = 35 };

            //Pascalcase   //camelCase
            ProduckManeger produckManeger = new ProduckManeger();
            produckManeger.Add(product1);
            Console.WriteLine(product1.productname);

            produckManeger.Topla2(45, 51);

            int tomlamsonuc = produckManeger.Topla(2, 3);
            Console.WriteLine(tomlamsonuc*2);
        }
    }
}
