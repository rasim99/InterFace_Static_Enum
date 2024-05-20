using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogTask
{
    internal class ProductCatalog
    {
        private Product[] products;
        Product[] Products {  get=>products; }
        public ProductCatalog()
        {
            products = new Product[0];
        }
        public void AddProduct(Product product)
        {
           
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
        }

        public void GetAllProducts()
        {
          if (products.Length>0)
            {
                foreach (Product product in products)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    product.GetDetails();
                    Console.ResetColor();
                    Console.WriteLine("------------------------------All_Products----------------------------------------\n \n");
                }
            }
            else
            {
                Console.WriteLine("Dont have product");
            }
        }

        public void GetAllProductsByType(Type type)
        {
            bool productFound=false;
            foreach (Product product in products)
            {
                if (product.Type==type)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    product.GetDetails();
                    Console.ResetColor();                  
                    Console.WriteLine("----------------------------Products_By_Typee--------------------------------------\n \n");
                    productFound = true;
                }
            }
            if (!productFound)
            {
                Console.WriteLine($"dont have product with the {type}");

            }
        }
    }
}
