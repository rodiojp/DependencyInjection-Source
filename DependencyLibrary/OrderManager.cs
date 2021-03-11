using System;

namespace DependencyLibrary
{
    public class OrderManager
    {
        public void Submit(Product product, string creditCardNumber, string expiryDate)
        {
            // Check product stock
            ProductStockRepo productStockRepo = new ProductStockRepo();
            if (!productStockRepo.IsInStock(product))
            {
                throw new Exception($"{product} is currently not in stock.");
            }
            // Payment
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.ChargeCreditCard(creditCardNumber, expiryDate);
            // Ship the product
            ShippingProcessor shippingProcessor = new ShippingProcessor();
            shippingProcessor.MailProduct(product);
            Console.WriteLine($"Order Manager: {product} has been shipped");
            productStockRepo.PrintStock();
        }
    }
}
