// using System.Collections.Generic;
// using System;
// using Microsoft.AspNetCore.Mvc;
// using VendorOrder.Models;

// namespace VendorOrder.Controllers
// {
//   public class VendorController : Controller
//   {

//     [HttpGet("/vendor")]
//     public ActionResult Index()
//     {
//       List<Vendor> allVendor = Vendor.GetAll();
//       return View(allVendor);
//     }

//     [HttpGet("/vendor/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/vendor")]
//     public ActionResult Create(string vendorName)
//     {
//       Vendor newVendor = new Vendor(vendorName);
//       return RedirectToAction("Index");
//     }

//     [HttpGet("/vendor/{id}")]
//     public ActionResult Show(int id)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Vendor selectedVendor = Vendor.Find(id);
//       List<Order> vendorOrders = selectedVendor.Order;
//       model.Add("vendor", selectedVendor);
//       model.Add("orders", vendorOrders);
//       return View(model);
//     }

//     // This one creates new Items within a given Category, not new Categories:
//     [HttpPost("/vendors/{vendorId}/orders")]
//     public ActionResult Create(int vendorId, string orderDescription)
//     {
//       Dictionary<string, object> model = new Dictionary<string, object>();
//       Vendor foundVendor = Vendor.Find(vendorId);
//       Order newOrder = new Order(orderDescription);
//       finddOrder.AddOrder(newOrder);
//       List<Order> vendorOrders = foundVendor.Orders;
//       model.Add("orders", categoryOrders);
//       model.Add("vendor", foundVendor);
//       return View("Show", model);
//     }

//   }
// }