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
            Order newOrder = new Order();
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}

       