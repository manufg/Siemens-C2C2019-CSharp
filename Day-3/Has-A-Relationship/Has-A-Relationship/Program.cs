using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_A_Relationship
{
    class Program
    {
        static void Main()
        {
            Category mobile = new Category { CategoryName = "Mobile", CategoryId = 1 };
            Category laptop = new Category { CategoryName = "Laptop", CategoryId = 2 };

            Category[] categoriesTable = new Category[] { mobile, laptop };

            Product iPhone = new Product
            {
                ProductName = "iPhone6",
                ProductId = 1,
                Description = "new mobile from apple",
                Price = 67000,
                CategoryInfo = mobile
            };
            Product motoG = new Product
            {
                ProductName = "Moto G5",
                ProductId = 2,
                Price = 13000,
                Description = "new mobile from motorola",
                CategoryInfo = mobile
            };
            Product hp = new Product
            {
                ProductName = "HP Probook",
                ProductId = 3,
                Price = 43000,
                Description = "new laptop from HP",
                CategoryInfo = laptop
            };
            Product dell = new Product
            {
                ProductName = "Dell XPS",
                ProductId = 4,
                Price = 143000,
                Description = "new laptop from Dell",
                CategoryInfo = laptop
            };

            Product[] productsTable = new Product[] { iPhone, motoG, hp, dell };

            //Console.WriteLine(iPhone.CategoryInfo.CategoryName);
            mobile.Products = new Product[] { productsTable[0], productsTable[1] };
            laptop.Products = new Product[] { productsTable[2], productsTable[3] };

            foreach (Category c in categoriesTable)
            {
                Console.WriteLine($"Category:{c.CategoryName}");
                Console.WriteLine("--------------------------------");
                foreach (Product p in c.Products)
                {
                    Console.WriteLine(p.ProductName);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            foreach (Product product in productsTable)
            {
                Console.WriteLine($"{product.ProductName} belongs to {product.CategoryInfo.CategoryName} category");
            }
        }
    }
}
