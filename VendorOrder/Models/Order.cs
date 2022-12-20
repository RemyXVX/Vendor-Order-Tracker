using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    //Title
    //Description
    //Price
    //Date

    private static List<Order> _instances = new List<Order> {};
  
    public string Name {get; set;}
    public string Description {get; set;}
    public string Date {get; set;}
    public int Price {get; set;}
    public int Id {get;}
    
    public Order(string name, string description, string date, int price)
    {
      Name = name;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int placeId)
    {
      return _instances[placeId - 1];
    }

  }
}