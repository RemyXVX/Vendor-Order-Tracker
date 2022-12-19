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
      Vendor newVendor = new Vendor("Bob the Builder", "He builds things");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Bob the Builder";
      Vendor newVendor = new Vendor(name, "He builds things");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "He build things";
      Vendor newVendor = new Vendor("Bob the Builder", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetAllVendors_ReturnAllVendors_List()
    {
      Vendor newVendor = new Vendor("Bob the Builder", "He builds things");
      Vendor newNewVendor = new Vendor("Thomas the train", "He goes vroom vroom");
      List<Vendor> vendorList = new List<Vendor> {newVendor, newNewVendor};
      CollectionAssert.AreEqual(vendorList, Vendor.GetAll());
    }

  }
}
