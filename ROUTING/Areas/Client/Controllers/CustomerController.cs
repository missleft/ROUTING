using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROUTING.Areas.Client.Controllers
{
    [RouteArea("Client")]
    [RoutePrefix("Customer")]
    public class CustomerController : Controller
    {
        [Route("Registration")]
        public ActionResult Registration()
        {
            return View();
        }

        [Route("Checkout/{orderid}")]
        public ActionResult Checkout(int orderid)
        {
            ViewBag.Data = orderid;
            return View();
        }

        [Route("Payment/{note:int}")]
        public ActionResult Payment(int note)
        {
            ViewBag.Data = note;
            return View();
        }        

        [Route("Tracking/{awb}")]
        public ActionResult Tracking(string awb)
        {
            ViewBag.Data = awb;
            return View();
        }
    }
}