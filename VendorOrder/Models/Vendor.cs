using System.Collections.Generic;

namespace VendorOrder.Models
{ 
 public class Vendor
  {
    private static List<Vendor> _vendor = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName)

    
{
    Name = vendorName;
    _vendor.Add(this);
    Id = _vendor.Count;
    Orders = new List<Order>{};
}

  }
}
  
    