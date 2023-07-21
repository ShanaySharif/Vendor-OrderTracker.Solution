
using System.Collections.Generic;
namespace VendorOrder.Models
{
    public class Order
    {

        public string Description { get; set; }
        public int Id { get; }
        private static List<Order> order = new List<Order> { };

        public Order(string description)
        {
            Description = description;
            order.Add(this);
            Id = order.Count;
        }









        // public string Name { get;}
        // public string  Description { get; }
        // private List <Vendor> Orders { get; set; }

        // private static List<Order> orders = new List<Order>();

        // public Order (string name, string description)
        // {
        //     Name = name;
        //     Description = description;
        //     orders.Add(this);
            
            




       
        }
    }
