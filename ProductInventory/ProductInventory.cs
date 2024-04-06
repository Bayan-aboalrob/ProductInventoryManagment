using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    internal class ProductInventory
    {
        private List<Product> products;
        public ProductInventory(List<Product> products)
        {
            this.products = products;
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public static void AddProduct(ProductInventory inventory)
        {
           
            Console.WriteLine("Please enter the product name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the product price:");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid price. Please enter a valid number:");
            }

            Console.WriteLine("Please enter the quantity of the product:");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.WriteLine("Invalid quantity. Please enter a valid number:");
            }

            inventory.products.Add(new Product(name, price, quantity));

            Console.WriteLine("Product added successfully !");
        }
        //Edit method for viewing a product modification options
        


    }

}
