using System;

namespace DependencyLibrary
{
    public class PaymentProcessor
    {
        public void ChargeCreditCard(string creditCardNumber, string expiryDate)
        {
            if (string.IsNullOrEmpty(creditCardNumber) || string.IsNullOrEmpty(expiryDate))
            {
                throw new Exception("Credit Card Number or Expiry Date are empty strings");
            }
            Console.WriteLine("Call to Credit Card API");
        }
    }
}