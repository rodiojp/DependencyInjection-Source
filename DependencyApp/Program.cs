using System;
using DependencyLibrary;
namespace DependencyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = string.Empty;
            OrderManager orderManager = new OrderManager();
            do
            {
                Console.WriteLine(@"Enter a product:
Keyboard = 0,
Mouse = 1,
Mic = 2,
Speaker = 3
                ");

                product = Console.ReadLine();
                if (product == "exit") break;
                try
                {
                    if (Enum.TryParse(product, out Product productEnum))
                    {
                        Console.WriteLine("Please enter a valid payment method: XXXX XXXX XXXX XXXX;MMYY");
                        var paymentMethod = Console.ReadLine();
                        if (string.IsNullOrEmpty(paymentMethod) || paymentMethod.Split(";").Length != 2)
                        {
                            throw new Exception("Payment method is invalid");
                        }
                        orderManager.Submit(productEnum, paymentMethod.Split(";")[0], paymentMethod.Split(";")[1]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(Environment.NewLine);
            } while (true);
        }
    }
}
