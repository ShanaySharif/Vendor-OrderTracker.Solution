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
    public class OrderTests: IDisposable
    { 

        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
             Order newOrder = new Order("test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "new cafe in the neighborhood.";

            Order newOrder = new Order(description);
            string result = newOrder.Description;

            Assert.AreEqual(description, result);
        }
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            
            string description = "new cafe in the neighborhood.";
            Order newOrder = new Order(description);

            string updatedDescription = "Get a cup of coffee";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            Assert.AreEqual(updatedDescription, result);
        }
        
        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
    
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }



        
        }
        
    }



       