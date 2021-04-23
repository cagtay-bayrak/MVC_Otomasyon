using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Otomasyon.Models.Classes;

namespace MVC5_Otomasyon.Controllers
{
    public class UrunController : Controller
    {
        Context cntxt = new Context();
        // GET: Urun
        public ActionResult Index()
        {
            var urunler = cntxt.Uruns.ToList();
            return View(urunler);
        }
    }
}