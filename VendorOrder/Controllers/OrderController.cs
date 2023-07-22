// using Microsoft.AspNetCore.Mvc;
// using VendorOrder.Models;
// using System.Collections.Generic;

// namespace VendorOrder.Controllers
// {
//   public class OrderController : Controller
//   {
//      [HttpGet("/vendors/{vendorsId}/orders/new")]
//     public ActionResult New(int vendorId)
//     {
//        Vendor vendor = Vendor.Find(vendorId);
//        return View(vendor);
//     }

//     [HttpGet("/vendors/{vedorId}/orders/{orderId}")]
//     public ActionResult Show(int vendorId, int orderId)
//     {
//       Order order = Order.Find(OrderId);
//       Vendor vendor = Vendor.Find(VendorId);
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       model.Add("order", order);
//       model.Add("vendor", vendor);
//       return View(model);
//     }
//   }
// }
