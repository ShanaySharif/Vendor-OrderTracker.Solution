
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
