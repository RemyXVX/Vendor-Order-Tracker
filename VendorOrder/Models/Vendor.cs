using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    //Name
    //Description
    //Orders

    public static List<Vendor> _instances = new List<Vendor> {};

    public string Name {get; set;}
    public string Description {get; set;}
    public string Order {get; set;}
    public List<Order> Orders {get; set;}

    public Vendor (string name, string description, string order)
    {
      Name = name;
      Description = description;
      Order = order;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}