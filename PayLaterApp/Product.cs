using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayLaterApp
{
    internal class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public int Price { get; set; }



        public static List<Product> GetProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ ProductName = "Mac Book Pro 2022" , ProductDescription = "Latest edition of Apple Mac Book", Price= 1500000},
                new Product(){ ProductName = "Dell Xps 2021" , ProductDescription = "Latest edition of Dell", Price= 2000000},
                new Product(){ ProductName = "Lenovo Lappad" , ProductDescription = "Latest edition of Lenovo", Price= 1000000},
                new Product(){ ProductName = "Asus Air" , ProductDescription = "Latest edition of Asus Laptop", Price= 1200000},
                new Product(){ ProductName = "Hp Slim X" , ProductDescription = "Latest edition of Hp Laptops", Price= 1300000},
            };

            return products;
        }
    }
}
