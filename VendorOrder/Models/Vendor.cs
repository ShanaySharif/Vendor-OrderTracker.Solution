using System.Collections.Generic;

namespace VendorOrder.Models
{ 
 public class Vendor
  {
    private static List<Vendor> _vendor = new List<Vendor> {};
    public string Description { get; set; }
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    // public Vendor(string vendorName, )
    // public Vendor( string description1, string title, string date, int price);
    public Vendor(string vendorName)

{
    Name = vendorName;
    _vendor.Add(this);
    Id = _vendor.Count;
    Orders = new List<Order>{};
}
  public static void ClearAll()
  {
    _vendor.Clear();
  }
  public static List<Vendor> GetAll()
    {
      return _vendor;
    }
     public static Vendor Find(int searchId)
    {
      return _vendor[searchId-1];
    }
    public void AddOrder(Order order)
  {
    Orders.Add(order);
  }
  }
}
  
  
    