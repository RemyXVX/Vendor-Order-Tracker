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
    public int Id {get; set;}
    public List<Order> Orders {get; set;}

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> {};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public static Vendor FindPlace(int placeId)
    {
      return _instances[placeId -1];
    }

  }
}