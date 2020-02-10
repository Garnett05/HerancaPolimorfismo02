using System;
using System.Collections.Generic;
using ExercicioHerancaPolimorfismoOO02.Entities;
using System.Globalization;

namespace ExercicioHerancaPolimorfismoOO02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int num = int.Parse(Console.ReadLine());
            List  <Product> list = new List<Product>();

            for (int i = 1; i <=num; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string prodName = Console.ReadLine();
                Console.Write("Price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime prodDate = DateTime.Parse(Console.ReadLine());
                    list.Add (new UsedProduct(prodName, prodPrice, prodDate));
                }
                else if (ch == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add (new ImportedProduct(prodName, prodPrice, customsProd));
                }
                else
                {
                    list.Add (new Product(prodName, prodPrice));
                }                
            }           
                        
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }

        }
    }
}