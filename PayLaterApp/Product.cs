using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayLaterApp
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int Price { get; set; }



        public static List<Product> ProductListStore()
        {
            List<Product> products = new List<Product>()
            {
                new Product(){ ProductId=1, ProductName = "Mac Book Pro 2022" , ProductDescription = "Latest edition of Apple Mac Book", Price= 1500000},
                new Product(){ ProductId=2, ProductName = "Dell Xps 2021" , ProductDescription = "Latest edition of Dell", Price= 2000000},
                new Product(){ ProductId=3, ProductName = "Lenovo Lappad" , ProductDescription = "Latest edition of Lenovo", Price= 1000000},
                new Product(){ ProductId=4, ProductName = "Asus Air" , ProductDescription = "Latest edition of Asus Laptop", Price= 1200000},
                new Product(){ ProductId=5, ProductName = "Hp Slim X" , ProductDescription = "Latest edition of Hp Laptops", Price= 1300000},
            };

            return products;
        }

        public void BuyProduct()
        {
            int _productSelection;

            Console.WriteLine("Welcome to Jumia Back Side Store");
            Console.WriteLine("Which product will you love to buy!");

            Renter_ProductSelection:
            Console.WriteLine("Product Name   |   Product Description       |    Price  ");
            
            foreach (var product in ProductListStore())
            {
                Console.WriteLine($" {product.ProductId}. {product.ProductName}  |  {product.ProductDescription} |  {product.Price}");
            }

            Console.WriteLine("Reply with the appropraite number for the product");
            if(int.TryParse(Console.ReadLine(), out _productSelection))
            {
                Console.WriteLine("Invalid Selection. Reply with a number that matches the porduct list");
                goto Renter_ProductSelection;
            }

            Console.WriteLine("Escaped");
            Product selectedProduct = ProductListStore().Find(x => x.ProductId == _productSelection);


            Console.WriteLine($"The product you selected is {selectedProduct.ProductName} and the Price is {selectedProduct.Price}");
            Console.WriteLine("How do you want to Pay? \n 1.Cash  \n 2.Installment?");


            if (int.Parse(Console.ReadLine()) == 1)
            {
                Console.WriteLine("You are ready to Pay in Cash! Go ahead and give the cashier the money");
            }
            if (int.Parse(Console.ReadLine()) == 2)
            {

                Console.WriteLine("You are ready to Pay by Installments! Select the payment plan that works best for you.");

                Console.WriteLine("1. Daily  \n 2. Weekly \n 3. Monthly  \n 4. Yearly ");
            }

        }

    }
}
