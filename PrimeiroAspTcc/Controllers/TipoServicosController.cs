using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrimeiroAspTcc.Data;
using PrimeiroAspTcc.Models;

namespace PrimeiroAspTcc.Controllers
{
    public class TipoServicosController : Controller
    {
        private PrimeiroAspTccContext db = new PrimeiroAspTccContext();

        // GET: TipoServicos
        public ActionResult Index()
        {
            return View(db.TipoServicoes.ToList());
        }

        // GET: TipoServicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoServico tipoServico = db.TipoServicoes.Find(id);
            if (tipoServico == null)
            {
                return HttpNotFound();
            }
            return View(tipoServico);
        }

        // GET: TipoServicos/Create
        public ActionResult Create()
        {
            var obj = new TipoServico();
            obj.Ativo = true;
            return View(obj);
        }

        // POST: TipoServicos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Descricao,Ativo")] TipoServico tipoServico)
        {
            if (ModelState.IsValid)
            {
                db.TipoServicoes.Add(tipoServico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoServico);
        }

        // GET: TipoServicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoServico tipoServico = db.TipoServicoes.Find(id);
            if (tipoServico == null)
            {
                return HttpNotFound();
            }
            return View(tipoServico);
        }

        // POST: TipoServicos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Descricao,Ativo")] TipoServico tipoServico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoServico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoServico);
        }

        // GET: TipoServicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoServico tipoServico = db.TipoServicoes.Find(id);
            if (tipoServico == null)
            {
                return HttpNotFound();
            }
            return View(tipoServico);
        }

        // POST: TipoServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoServico tipoServico = db.TipoServicoes.Find(id);
            db.TipoServicoes.Remove(tipoServico);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
