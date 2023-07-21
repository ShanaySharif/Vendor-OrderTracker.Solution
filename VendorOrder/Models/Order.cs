
using System.Collections.Generic;
namespace VendorOrder.Models
{
    public class Order
    {
        public string Description { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
       
        }
    }