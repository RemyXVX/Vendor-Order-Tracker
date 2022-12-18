using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatsOrder_Order()
    {
      Order newOrder = new Order("order", "it be stuff", "jan 1", 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}