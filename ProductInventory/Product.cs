using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventory
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private int _quantity;

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id++;
            }
        }

        public Product(string name, double price, int quantity)
        {
            _id = GetNextProductId(); // for Setting _id to a unique identifier
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        private static int nextProductId = 1;

        private static int GetNextProductId()
        {
            return nextProductId++;
        }
        public override string ToString()
        {
            return $"Product ID: {_id}, Name: {Name}, Price: {Price:C}, Quantity: {Quantity}";
        }
    }

}
