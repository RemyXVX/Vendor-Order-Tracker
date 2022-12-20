using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> currentVendors = Vendor.GetAll();
      return View(currentVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(Id);
      List<Order> order = vendor.Orders;
      model.Add("vendors", vendor);
      model.Add("orders", order);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(string title, string description, string date, int price, int vendorId)
    {
      Vendor findVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, date, price);
      findVendor.AddOrder(newOrder);
      return RedirectToAction("index");
    }

  }
}