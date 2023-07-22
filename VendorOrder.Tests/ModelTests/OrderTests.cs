using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
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
            int price = 25;

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
        public void GetOrderDescription_ReturnsDescription_String()
        {
            //Arrange 
            string description = "Test order description";
            string date = "2023-07-22";
            string title = "Test order title";
            int price = 25;

            Order order = new Order(description, date, title, price);

            //ACT
            string retrievedDescription = order.Description;
            //Assert
            Assert.AreEqual(description, retrievedDescription);
        }
        [TestMethod]
        public void GetOrderTitle_ReturnsTitle_String()
        {
            //Arrange 
            string description = "Test order description";
            string date = "2023-07-22";
            string title = "Test order title";
            int price = 25;

            Order order = new Order(description, date, title, price);

            //ACT
            string retrievedTitle = order.Title;
            //Assert
            Assert.AreEqual(title, retrievedTitle);
        }

        [TestMethod]
        public void GetDate_ReturnsDate_Date()
        {
            //Arrange 
            string description = "Test order description";
            string date = "2023-07-22";
            string title = " Order title";
            int price = 25;

            Order order = new Order(description, date, title, price);

            //ACT
            string retrievedDate = order.Date;
            //Assert
            Assert.AreEqual(date, retrievedDate);

        }
        [TestMethod]
        public void GetPrice_ReturnsPrice_Price()
        {
            //Arrange 
            string description = "Test order description";
            string date = "2023-07-22";
            string title = " Order title";
            int price = 25;

            Order order = new Order(description, date, title, price);

            //ACT
            int retrievedPrice = order.Price;
            //Assert
            Assert.AreEqual(price, retrievedPrice);
        }
        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 25;
            string date1 = "2023-07-22";
            string title2 = "Title Two";
            string description2 = "Description Two";
            int price2 = 50;
            string date2 = "2023-07-22";
            Order newOrder1 = new Order(description1, date1, title1, price1);
            Order newOrder2 = new Order(description2, date2, title2, price2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newList, result);

        }
        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 25;
            string date1 = "2023-07-22";

            Order newOrder = new Order(description1, date1, title1, price1);

            int result = newOrder.Id;

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            string title1 = "Title One";
            string description1 = "Description One";
            int price1 = 25;
            string date1 = "2023-07-22";
            string title2 = "Title Two";
            string description2 = "Description Two";
            int price2 = 50;
            string date2 = "2023-07-22";
            Order newOrder1 = new Order(description1, date1, title1, price1);
            Order newOrder2 = new Order(description2, date2, title2, price2);


            Order result = Order.Find(2);

            Assert.AreEqual(newOrder2, result);

            // {
            //     [TestMethod]
                // public void AddOrder_TargetsVendorOrder_Order()
                // {
                //     string title1 = "Title One";
                //     string description1 = "Description One";
                //     int price1 = 25;
                //     string date1 = "2023-07-22";
                //     string title2 = "Title Two";
                //     string description2 = "Description Two";
                //     int price2 = 50;
                //     string date2 = "2023-07-22";
                //     Order newOrder1 = new Order(description1, date1, title1, price1);
                //     Vendor newOrder2 = new Order(description2, date2, title2, price2);


                //     Order result = Order.Find(2);

                //     Assert.AreEqual(newOrder2, result);

                }
            }

        }





       