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
        public void 
        OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            // Arrange
        string description = "Test order description";
        string date = "2023-07-22";
        string title = "Test order title";
        int price = 100;

        // Act
        Order order = new Order(description, date, title, price);

        // Assert
        Assert.AreEqual(description, order.Description);
        Assert.AreEqual(date, order.Date);
        Assert.AreEqual(title, order.Title);
        Assert.AreEqual(price, order.Price);
        Assert.AreEqual(1, order.Id);
    }


        [TestMethod]
        public void GetOrder_ReturnsTitle_Title()
        {
        //     //Arrange 
        //     string description = "Test order description";
        //     string date = "2023-07-22";
        //     string title = "Test order title";
        //     int price = 25;

        //     Order order = new Order(description, date, title, price);

        //     //ACT
        //     string retrievedTitle = order.Title;
        //     //Assert
        //     AssemblyLoadEventArgs.AreEqual(title,retrievedTitle);

    
        // }

        //  [TestMethod]
        // public void GetTitle_ReturnsDate_Date()
        // {
        //     string date = "title";
        //     Order newOrder = new Order(description,"7/21/23", 25,"title" );
        //     string result = newOrder.Title;

        //     Assert.AreEqual(Date, result);
        // }
        // [TestMethod]
        // public void GetDescription_ReturnsDescription_String()
        // {
        //     string description = "description";

        //     Order newOrder = new Order(description,"7/21/23", 25,"title" );
        //     string result = newOrder.Description;

        //     Assert.AreEqual(description, result);
        // }

        
        // [TestMethod]
        // public void GetPrice_ReturnPrice_Price()
        // {
            
        //     int price = 25;
        //     Order newOrder = new Order("description", "7/21/2023", 25, "title");

        //     int result = newOrder.Price;
        //     Assert.AreEqual(price, result);
        // }
        
        // [TestMethod]
        // public void GetAll_ReturnsEmptyList_OrderList()
        // {
    
        //     List<Order> newList = new List<Order> { };
        //     List<Order> result = Order.GetAll();
        //     CollectionAssert.AreEqual(newList, result);
        }



        
        }
        
    }



       