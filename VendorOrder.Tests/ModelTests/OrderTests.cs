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
             Order newOrder = new Order("test");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "new cafe in the neighborhood.";

            //Act
            Order newOrder = new Order(description);
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(description, result);
        }
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "new cafe in the neighborhood.";
            Order newOrder = new Order(description);

            //Act
            string updatedDescription = "Get a cup of coffee";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }






    //         string name = "Cafe";
    //         string description = "neighborhood cafe";

    //         Order test = new Order(name, description);

    //         Assert.AreEqual(name, test.Name);
    //         Assert.AreEqual(description, test.Description);
        
    //     }
    //    [TestMethod]
    //     public void GetDescription_ReturnsDescription_string()
    //     {
    //         string name = "Cafe";
    //         string description = "neighborhood cafe";

    //         Order test = new Order(name, description);

    //         Assert.AreEqual(name, test.Name);
    //         Assert.AreEqual(description, test.Description);
        
        }
        
    }
// }


       