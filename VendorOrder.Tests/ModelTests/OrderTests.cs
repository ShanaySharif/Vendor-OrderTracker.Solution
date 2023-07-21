using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

//Properties for title: Donuts
//Description: Jelly
//Price: $25
//Date: 7/21/23
//int id = 0;

namespace VendorOrder.Tests
{
    [TestClass]
    public class OrderTests
    { 

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            string name = "Cafe";
            string description = "neighborhood cafe";

            Order test = new Order(name, description);

            Assert.AreEqual(name, test.Name);
            Assert.AreEqual(description, test.Description);
        
        }
        
        
    }
}


       