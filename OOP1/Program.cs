namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 100;
            product1.UnitInStock = 5;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 2,
                ProductName = "Dolap",
                UnitPrice = 200,
                UnitInStock = 5
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);
            
            Console.ReadLine();
        }
    }
}