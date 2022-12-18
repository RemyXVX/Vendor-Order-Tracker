using System.Collections.Generic;
using System;
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

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return Redirect("/");
    }


    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll();
      return View();
    }

  // [HttpPost("/vendors")]
  //   public ActionResult Create(string title, string description, string date, int price)
  //   {
  //     Order newOrder = new Order(title, description, date, price);
  //     return RedirectToAction("Index");
  //   }



  }
}