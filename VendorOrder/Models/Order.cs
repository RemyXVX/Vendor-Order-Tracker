using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    //Title
    //Description
    //Price
    //Date

    public static List<Order> _instances = new List<Order> {};
  
    public string Title {get; set;}
    public string Description {get; set;}
    public string Date {get; set;}
    public int Price {get; set;}
    
    public Order(string title, string description, string date, int price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}