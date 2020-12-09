using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROUTING.Areas.Client.Controllers
{
    [RouteArea("Client")]
    [RoutePrefix("Supplier")]
    public class SupplierController : Controller
    {
        [Route("Registration")]
        public ActionResult Registration()
        {
            return View();
        }

        [Route("Order/{note:int}")]
        public ActionResult Order(int note)
        {
            ViewBag.Data = note;
            return View();
        }

        [Route("Shipment/{awb}")]
        public ActionResult Shipment(string awb)
        {
            ViewBag.Data = awb;
            return View();
        }
    }
}