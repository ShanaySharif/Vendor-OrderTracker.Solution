using System.Collections.Generic;
//seperate the static from dynamic classes
//orders = static class that keeps track of All the orders
//a vendor keep track of their orders
// Vendors - 
// vendor -
// order- 


//List properties and methods
//methods are for managing properties in non static classes
//static classes: more persistant information or performing calculations

namespace VendorOrder.Models
{
    public class order
    {
        public string Description { get; set; } //automatic property
        public int Id { get; }
        private static List<Item> _instances = new List<Item> { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Item Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}