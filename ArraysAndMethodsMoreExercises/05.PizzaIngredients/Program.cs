using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ');
            var maxLength = int.Parse(Console.ReadLine());
            var counter = 0;

            string[] addedProducts = new string[10];

            for (int i = 0; i < products.Length; i++)
            {
                string addProduct = products[i];
                if (counter == 10) break;

                if (addProduct.Length == maxLength)
                {
                    Console.WriteLine($"Adding {addProduct}.");
                    addedProducts[counter] = addProduct;
                    counter++;
                }
            }
            Array.Resize(ref addedProducts, counter);
            
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine("The ingredients are: " + string.Join(", ", addedProducts) + ".");
        }
    }
}
