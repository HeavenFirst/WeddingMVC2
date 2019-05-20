using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC2.Models;
using System.Data.Entity;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        WedContext db = new WedContext();
        public ActionResult Index()
        {
            var couples = db.Couples;
            ViewBag.Couples = couples;
            return View();
        }

        [HttpGet]
        public ActionResult CreateVariant()
        {
            SelectList SLCoup = new SelectList( db.Couples, "Id", "Surname");
            var coup = new Variant();
            if (SLCoup != null)
            {
                ViewBag.Coups = SLCoup;
                return View(coup);
            }
            else return HttpNotFound();
        }

        [HttpPost]
        public ActionResult CreateVariant(Variant v)
        {
            db.Variants.Add(v);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Buy(int Id = 0)
        {
            if (Id == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Variant varik = new Variant { CoupleID = Id, toustmuster = "Пока неизвестно кто!", Musicion= "Музыкант???", Decor="Вводить сюда!" };
                return View(varik);
            }
        }
        [HttpPost]
        public ActionResult Buy(Variant vr)
        {
            db.Variants.Add(vr);
            db.SaveChanges();
            string rez ="Ввыбрали: " + vr.toustmuster + " " + vr.Musicion + " " + vr.Decor+" "+vr.CoupleID ;
            ViewBag.rez = rez;
            return View("BuyPost");
        }
        [HttpGet]
        public ActionResult Look(int id=0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            List<Variant> vars = db.Variants.ToList();
            List<Variant> varsSelected= new List<Variant>();
            foreach (var vari in vars)
            {
                if (vari!=null && vari.CoupleID == id) { varsSelected.Add(vari); }
            }
            
             if (varsSelected != null) { return View(varsSelected); }
            else { return HttpNotFound(); }
        }

        [HttpGet]
        public ActionResult Create()
        {
           return View();
        }

        [HttpPost]
        public ActionResult Create(Couple coup)
        {
            if(coup != null)
            {
                coup.RegistrationDay = DateTime.Now;
                db.Couples.Add(coup);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id=0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            Couple varik2 = db.Couples.Find(id);
            if (varik2 != null) { return View(varik2); }
            else { return HttpNotFound(); }
        }
       
        [HttpPost]
        public ActionResult Edit(Couple varik)
        {
            db.Entry(varik).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}