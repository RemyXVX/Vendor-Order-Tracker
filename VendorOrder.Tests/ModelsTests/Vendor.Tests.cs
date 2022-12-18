using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreateVendorOrder_Vendor()
    {
      Vendor newVendor = new Vendor("Bob the Builder", "He builds things", "A stack of wood");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  }
}
