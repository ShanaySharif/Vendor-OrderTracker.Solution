
using System.Collections.Generic;
namespace VendorOrder.Models
{
    public class Order
    {

        public string Description { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public int Id { get; }
        private static List<Order> order = new List<Order> { };


        public Order(string description, string date, string title, int price)
        {
            Description = description;
            Date = date;
            Price = price;
            Title = title;

            order.Add(this);
            Id = order.Count;
        }
        public static List<Order> GetAll()
        {
            return order;
        }
        public static void ClearAll()
        {
            order.Clear();
        }
        public static Order Find(int searchId)
        {
            return order[searchId - 1];
        }




    }
}
