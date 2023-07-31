using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
{
     [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }
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

 [TestMethod]
        public void GetAll_ReturnsAllVendors_VendorList()
        {
            // Arrange
            Vendor vendor1 = new Vendor("Vendor 1");
            Vendor vendor2 = new Vendor("Vendor 2");
            Vendor vendor3 = new Vendor("Vendor 3");
            
            List<Vendor> allVendors = Vendor.GetAll();

            Assert.AreEqual(3, allVendors.Count);
            Assert.IsTrue(allVendors.Contains(vendor1));
            Assert.IsTrue(allVendors.Contains(vendor2));
            Assert.IsTrue(allVendors.Contains(vendor3));

            
            
        }

    }
}

    