using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Arrays_Indexes_task2
{

    class Program
    {
        static void DisplayInformation(Article article)
        {
            Console.WriteLine(String.Format("Information about product: ProductName - {0}, StoreName - {1}, Price = {2}", article.ProductName, article.StoreName, article.Price));
        }

        static void Main(string[] args)
        {
            Store store = new Store(3);
            DisplayInformation(store[0]);
            DisplayInformation(store[1]);
            DisplayInformation(store[2]);

            Console.WriteLine("Please enter the name of the product");
            string name = Console.ReadLine();
            try
            {
                DisplayInformation(store[name]);
            }
            catch
            {
                Console.WriteLine("There os no product with such name");
            }
            Console.ReadKey();
        }
    }
}
