using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROUTING.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("AdminCustomer")]
    public class AdminCustomerController : Controller
    {
        [Route("Customer/{id:int}")]
        public ActionResult Customer(int id)
        {
            ViewBag.Data = id;
            return View();
        }

        [Route("Shipment/{awb}")]
        public ActionResult Shipment(string awb)
        {
            ViewBag.Data = awb;
            return View();
        }

        [Route("Payin")]
        public ActionResult Payin()
        {
            return View();
        }

    }
}