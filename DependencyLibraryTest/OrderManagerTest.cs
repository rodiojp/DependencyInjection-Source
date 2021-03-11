using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyLibrary;
using System;

namespace DependencyLibraryTest
{
    [TestClass]
    public class OrderManagerTest
    {
        [TestMethod]
        [DataRow(Product.Keyboard, "1010101010101010", "0622")]
        [ExpectedException(typeof(Exception), "Keyboard is currently not in stock.")]
        public void OrderManagerSubmitTest(Product product, string creditCardNumber, string expiryDate)
        {
            // Tests that we expect to return true.
            OrderManager orderManager = new OrderManager();
            orderManager.Submit(product, creditCardNumber, expiryDate);
            
            // Sipping the same product to generate availability Exception
            orderManager.Submit(product, creditCardNumber, expiryDate);
        }

    }
}
