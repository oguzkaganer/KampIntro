using System;

namespace LinqProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new()
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"}
            };

            List<Product> products = new()
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB RAM",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB RAM",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB RAM",UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuantityPerUnit="4 GB RAM",UnitPrice=8000,UnitsInStock=0}
            };

            //Test(products);,

            //AnyTest(products);

            //FindTest(products);

            //FindAllTest(products);

            //AscDescTest(products);

            //Test2(products);

            //Test3(products);

            //ClassicLinqTest(products);

            //JoinTest(categories, products);

            Console.ReadLine();
        }

        private static void JoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice, CategoryName = c.CategoryName };

            foreach (var product in result)
            {
                Console.WriteLine("{0} - {1} : {2}", product.ProductName, product.CategoryName, product.UnitPrice);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.ProductName, p.UnitPrice
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void Test3(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.ProductName, p.UnitPrice
                         select p.ProductName +" - "+ p.UnitPrice;

            foreach (var product in result)
            {
                Console.WriteLine(product);
            }
        }

        private static void Test2(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.ProductName, p.UnitPrice
                         select p;

            foreach (Product product in result)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("Laptop")).OrderBy(p => p.UnitPrice).ThenByDescending(p => p.ProductName);

            foreach (Product product in result)
            {
                Console.WriteLine("{0} - {1}", product.ProductName, product.UnitPrice);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("Laptop"));

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 15);

            Console.WriteLine(result?.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Acer Laptop");

            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("\nAlgoritmik------------\n");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("\nLinq------------------\n");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("\nLinq Method------------------\n");

            var result1 = GetProductsLinq(products);

            foreach (var product in result1)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProduct.Add(product);
                }
            }
            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
        }

    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}