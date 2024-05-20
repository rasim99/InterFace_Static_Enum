using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogTask
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Type Type { get; set; }
     

        public Product(string name, int price, Type type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Product Name : {Name}  " +
                       $"Product Price :  {Price}  " +
                       $"Product Type : {Type}");
        }
    }
}
