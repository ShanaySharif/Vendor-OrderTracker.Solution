
using System.Collections.Generic;
namespace VendorOrder.Models
{
    public class Order
    {
        public string Name { get;}
        public string  Description { get; }
        private List <Vendor> _vendors { get; set; }

        private static List<Order> _orders = new List<Order>();

        // public Order (string name, string description)
    //     {
    //         // Name = name;
    //         // description = description;
    //         // _orders = new List<Order>();
    //         // _vendors.Add(this);


    //     }

       
        }
    }
