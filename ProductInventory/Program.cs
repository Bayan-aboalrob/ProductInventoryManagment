using System;
namespace ProductInventory
{
    public class Program
    {
        public static void MainMenu()
        {
            Console.WriteLine("Please choose one of the following option");
            Console.WriteLine("******************************************");
            Console.WriteLine("1. Add A Product");
            Console.WriteLine("2. View Inventory");
            Console.WriteLine("3. Edit A Product");
            Console.WriteLine("4. Delete A Product");
            Console.WriteLine("5. Search For A Product");
            Console.WriteLine("6. Exit");
        }
        public static void EditMenu()
        {
            Console.WriteLine("Please choose one of the following option");
            Console.WriteLine("******************************************");
            Console.WriteLine("1. Edit Quantity");
            Console.WriteLine("2. Edit Price");

        }

        static void Main(string[] args)
        {
            // Instantiating Two Products
            Product P1 = new Product("Chetos", 3, 7);
            Console.WriteLine(P1);
            Product P2 = new Product("Lays", 9, 7);
            Console.WriteLine(P2);

            // Instantiating A list of Poducts
            List<Product> products = new List<Product>();
            products.Add(P1);
            products.Add(P2);

            // Instantiating An Inventory
            ProductInventory Inventory = new ProductInventory(products);

            Console.WriteLine("Welcome to Inventory Management System !");

            String userInput;
            int userOption = 0;


            while (true)
            {
                // Viewing the main Menu
                Program.MainMenu();
                // Choosing An Option
                userInput = Console.ReadLine();

                // Converting the option to int
                if (!int.TryParse(userInput, out userOption))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }

                switch (userOption)
                {
                    case 1:

                        ProductInventory.AddProduct(Inventory);
                        break;
                    case 2:
                        Console.WriteLine("View Inventory");
                        ProductInventory.ViewInventory(Inventory);
                        break;
                    case 3:
                        ProductInventory.EditProduct(Inventory);
                        Console.WriteLine("Edit Inventory");

                        break;
                    case 4:
                        Console.WriteLine("Delete A Product");
                        break;
                    case 5:
                        Console.WriteLine("Search For A Product");
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 6.");
                        break;
                }
            }


        }

    }
}