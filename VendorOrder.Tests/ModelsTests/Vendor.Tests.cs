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

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string name = "Bob the Builder";
      Vendor newVendor = new Vendor(name, "He builds things", "A stack of wood");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string description = "He build things";
      Vendor newVendor = new Vendor("Bob the Builder", description, "A stack of wood");
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetOrder_ReturnOrder_String()
    {
      string order = "A stack of wood";
      Vendor newVendor = new Vendor("Bob the Builder", "He builds things", order);
      string result = newVendor.Order;
      Assert.AreEqual(order, result);
    }

    [TestMethod]
    public void GetAllVendors_ReturnAllVendors_List()
    {
      Vendor newVendor = new Vendor("Bob the Builder", "He builds things", "A stack of wood");
      Vendor newNewVendor = new Vendor("Thomas the train", "He goes vroom vroom", "A stack of coal");
      List<Vendor> vendorList = new List<Vendor> {newVendor, newNewVendor};
      CollectionAssert.AreEqual(vendorList, Vendor.GetAll());
    }

  }
}
