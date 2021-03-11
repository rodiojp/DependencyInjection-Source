using System;

namespace DependencyLibrary
{
    public class ShippingProcessor
    {
        public void MailProduct(Product product)
        {
            ProductStockRepo productStockRepo = new ProductStockRepo();
            productStockRepo.ReduceStock(product);
            Console.WriteLine("Call to Shipping Processor API");
        }
    }
}