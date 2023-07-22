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
    }

    
}

    