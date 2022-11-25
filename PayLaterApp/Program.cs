namespace PayLaterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jumia Back Side Store");
            Console.WriteLine("Which product will you love to buy!");

         Console.WriteLine("Product Name                            |   Product Description       |    Price  ");

            foreach (var product in Product.GetProductList())
            {
                Console.WriteLine($"1. {product.ProductName}  |  {product.ProductDescription} |  {product.Price}");
            }
        }
    }
}