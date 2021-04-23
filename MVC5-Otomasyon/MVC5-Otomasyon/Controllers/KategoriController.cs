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
        Context cntxt = new Context();
        public ActionResult Index()
        {
            var values = cntxt.Kategoris.ToList();
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
            try
            {
                cntxt.Kategoris.Add(k);
                cntxt.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public ActionResult KategoriDelete(int id)
        {
            try
            {
                var ktg = cntxt.Kategoris.Find(id);
                cntxt.Kategoris.Remove(ktg);
                cntxt.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        // Kategori güncellemek için kayıtları getir
        public ActionResult Kategoribring(int id)
        {
            var ktg = cntxt.Kategoris.Find(id);
            return View("Kategoribring", ktg);
        }

        //güncelle KategoriUpdate viwede
        public ActionResult KategoriUpdate(Kategori k)
        {
            try
            {
                var ktg = cntxt.Kategoris.Find(k.KategoriID);
                ktg.KategoriAd = k.KategoriAd;
                cntxt.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }



    }
}