using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Otomasyon.Models.Classes;

namespace MVC5_Otomasyon.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Kategoris.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kategori k)
        {

            c.Kategoris.Add(k);
            c.SaveChanges();

            return RedirectToAction("Index");

        }

    }
}