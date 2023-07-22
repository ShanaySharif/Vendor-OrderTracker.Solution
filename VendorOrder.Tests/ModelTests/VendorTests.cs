using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

 //properties of vendor name
    //description of vendor 
    //list of orders belonging to vendors 

namespace VendorOrder.Tests
{

    public class VendorTests
    {
        [TestMethod]
        public void
        VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
      Vendor newVendor = new Vendor("New Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
        [TestMethod]
        public void
        GetId_CreatesVendorId_VendorInt()
        {
            string name = "Vendor Name";
            Vendor newVendor = new Vendor(name);

            int result = newVendor.Id;
            Assert.AreEqual(1, result);
    }
    [TestMethod]
        public void
        Find_ReturnsVendor_Vendor()
        {
            string name1 = "Vendor One";
            string name2 = "Vendor Two";
            Vendor newVendor1 = new Vendor(name1);
            Vendor newVendor2 = new Vendor(name2);

            Vendor result = Vendor.Find(2);

            Assert.AreEqual(newVendor2, result);
        }

    }
}

    