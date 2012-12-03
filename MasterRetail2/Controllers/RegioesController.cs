using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rcky.MasterRetail2.Entities;
using MasterRetail2.Models;

namespace MasterRetail2.Controllers
{   
    public class RegioesController : Controller
    {
        private MasterRetail2Context context = new MasterRetail2Context();

        //
        // GET: /Regioes/

        public ViewResult Index()
        {
            return View(context.Regioes.ToList());
        }

        //
        // GET: /Regioes/Details/5

        public ViewResult Details(int id)
        {
            Regiao regiao = context.Regioes.Single(x => x.RegiaoId == id);
            return View(regiao);
        }

        //
        // GET: /Regioes/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Regioes/Create

        [HttpPost]
        public ActionResult Create(Regiao regiao)
        {
            if (ModelState.IsValid)
            {
                context.Regioes.Add(regiao);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(regiao);
        }
        
        //
        // GET: /Regioes/Edit/5
 
        public ActionResult Edit(int id)
        {
            Regiao regiao = context.Regioes.Single(x => x.RegiaoId == id);
            return View(regiao);
        }

        //
        // POST: /Regioes/Edit/5

        [HttpPost]
        public ActionResult Edit(Regiao regiao)
        {
            if (ModelState.IsValid)
            {
                context.Entry(regiao).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regiao);
        }

        //
        // GET: /Regioes/Delete/5
 
        public ActionResult Delete(int id)
        {
            Regiao regiao = context.Regioes.Single(x => x.RegiaoId == id);
            return View(regiao);
        }

        //
        // POST: /Regioes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Regiao regiao = context.Regioes.Single(x => x.RegiaoId == id);
            context.Regioes.Remove(regiao);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}