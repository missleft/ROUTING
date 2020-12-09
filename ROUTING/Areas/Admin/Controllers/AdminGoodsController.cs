using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ROUTING.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("AdminGoods")]
    public class AdminGoodsController : Controller
    {
        [Route("Supplier/{id:int}")]
        public ActionResult Supplier(int id)
        {
            ViewBag.Data = id;
            return View();
        }

        [Route("Stock")]
        public ActionResult Stock()
        {
            return View();
        }

        [Route("Payout/{note}")]
        public ActionResult Payout(string note)
        {
            ViewBag.Data = note;
            return View();
        }

        [Route("Receivement/{goodsid:int}")]
        public ActionResult Receivement(int goodsid)
        {
            ViewBag.Data = goodsid;
            return View();
        }


    }
}