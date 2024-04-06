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

            Product P = inventory.GetProducts().Find(prod => prod.Name.ToLower() == name.ToLower());
            if(P != null)
            {
                P.Quantity += quantity;
                Console.WriteLine($"{P.Name} quantity is updated successfully");
            }
            else
            {
                inventory.products.Add(new Product(name, price, quantity));
                Console.WriteLine("Product added successfully !");
            }
        

           
        }
        //Edit method for viewing a product modification options

        public static void EditMenu()
        {
            Console.WriteLine("Please choose one of the following option");
            Console.WriteLine("******************************************");
            Console.WriteLine("1. Edit Quantity");
            Console.WriteLine("2. Edit Price");

        }

        // This a method for editing a product details based on the user choice: whether to edit
        // the price or the quantity
        public static void EditProduct(ProductInventory inventory)
        {
            Console.WriteLine("Please enter the name of the product you want to edit:");
            string productName = Console.ReadLine();

            Product product = inventory.GetProducts().Find(p => p.Name.ToLower() == productName.ToLower());

            if (product != null)
            {
                EditMenu();
                string editOption = Console.ReadLine();
                int convertedEditOption;

                if (int.TryParse(editOption, out convertedEditOption))
                {
                    switch (convertedEditOption)
                    {
                        case 1:
                            Console.WriteLine("Please enter the new quantity of the product:");
                            int newQuantity;
                            while (!int.TryParse(Console.ReadLine(), out newQuantity))
                            {
                                Console.WriteLine("Invalid quantity. Please enter a valid number:");
                            }
                            product.Quantity = newQuantity;
                            Console.WriteLine("Quantity updated successfully !");
                            break;
                        case 2:
                            Console.WriteLine("Please enter the new price of the product:");
                            double newPrice;
                            while (!double.TryParse(Console.ReadLine(), out newPrice))
                            {
                                Console.WriteLine("Invalid price. Please enter a valid number:");
                            }
                            product.Price = newPrice;
                            Console.WriteLine("Price updated successfully !");
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
        // View all product details:

        public static void ViewInventory(ProductInventory inventory)
        {
            if (inventory == null)
            {
                Console.WriteLine("Inventory is null.");
                return;
            }

            if (inventory.products.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("Inventory:");
            foreach (Product p in inventory.products)
            {
                Console.WriteLine(p);
            }
        }

        // Delete a product Method

        public static void DeleteProduct(ProductInventory inventory)
        {
            Console.WriteLine("Enter the name of the product to delete:");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid product name.");
                return;
            }
            Product product = inventory.GetProducts().Find(p => p.Name.ToLower() == name.ToLower());
            if (product != null)
            {
                inventory.products.Remove(product);
                Console.WriteLine($"{product.Name} is deleted successfully");
            }
            else
            {
                Console.WriteLine("The product doesn't exist  in the inventory");
            }

        }


        // This method is used for searching for a product in the inventory, if it exits it prints all its details
        //  else it prints "this product doesn't exist in the inventory"
        public static void SearchProductByName(ProductInventory inventory)
        {
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid product name.");
                return;
            }
            Product product = inventory.GetProducts().Find(p => p.Name.ToLower() == name.ToLower());
            if (product != null)
            {
                Console.WriteLine("Here is the info of the product you are searching about");
                Console.WriteLine($"{product}");
            }
            else
            {
                Console.WriteLine("The product doesn't exist  in the inventory");
            }
        }

    }

}
