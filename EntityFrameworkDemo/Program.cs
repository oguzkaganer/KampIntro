using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;

namespace EntityFrameworkDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetAll();
            GetProductsByCategory(2);




            Console.ReadLine();
        }

        private static void GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                foreach (var product in context.Products)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext context = new NorthwindContext();
            int i;


            //var result = context.Products.Where(p=>p.CategoryID==categoryId).ToList();
            //
            //
            //i = 1;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(i+". "+item.ProductName);
            //    i++;
            //}

            var result2 = context.Products
                .Join(context.Categories, p => p.CategoryID, c => c.CategoryID, (p, c) => new { p, c })
                .Where(p => p.p.CategoryID == categoryId)
                .ToList();

            i = 1;
            foreach (var item in result2)
            {
                    Console.WriteLine(i + ". " + item.p.ProductName + " - " + item.c.CategoryName);
                    i++;
                
            }


            //var result3 = from product in context.Products
            //              join category in context.Categories on product.CategoryID equals category.CategoryID
            //              where product.CategoryID == categoryId
            //              select new { product, category };
            //i = 1;
            //foreach (var item in result3)
            //{
            //    Console.WriteLine(i + ". " + item.product.ProductName + " - " + item.category.CategoryName);
            //    i++;
            //}


        }
    }
}