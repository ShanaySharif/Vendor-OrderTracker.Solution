
using System.Collections.Generic;
namespace VendorOrder.Models
{
    public class Order
    {
        public string Name { get;}
        public string  Description { get; }
        private List <Vendor> Orders { get; set; }

        private static List<Order> orders = new List<Order>();

        public Order (string name, string description)
        {
            Name = name;
            Description = description;
            orders.Add(this);
            
            


        }

       
        }
    }
