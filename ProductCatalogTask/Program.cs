namespace ProductCatalogTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1=new Product("Huawei p50pro" ,250,Type.Electronics);
            Product product2=new Product("Iphone 15 promax" ,2250,Type.Electronics);
            Product product3=new Product("LV " ,400,Type.Clothing);
            Product product4=new Product("EA7 " ,300,Type.Clothing);
            ProductCatalog catalog=new ProductCatalog();
            catalog.AddProduct(product1);
            catalog.AddProduct(product2);
            catalog.AddProduct(product3);
            catalog.AddProduct(product4);
            catalog.GetAllProducts();
            catalog.GetAllProductsByType(Type.Electronics);
            catalog.GetAllProductsByType(Type.Groceries);
        }
    }
}
