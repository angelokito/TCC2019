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
    public class ClienteServicosController : Controller
    {
        private PrimeiroAspTccContext db = new PrimeiroAspTccContext();

        // GET: ClienteServicos
        public ActionResult Index()
        {
            var clienteServico = db.ClienteServico.Include(c => c.Cliente).Include(c => c.TipoServico);
            return View(clienteServico.ToList());
        }

        // GET: ClienteServicos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteServico clienteServico = db.ClienteServico.Find(id);
            if (clienteServico == null)
            {
                return HttpNotFound();
            }
            return View(clienteServico);
        }

        // GET: ClienteServicos/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome");
            ViewBag.TipoServicoId = new SelectList(db.TipoServicoes, "Id", "Descricao");
            return View();
        }

        // POST: ClienteServicos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClienteServicoId,ClienteId,TipoServicoId")] ClienteServico clienteServico)
        {
            if (ModelState.IsValid)
            {
                db.ClienteServico.Add(clienteServico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome", clienteServico.ClienteId);
            ViewBag.TipoServicoId = new SelectList(db.TipoServicoes, "Id", "Descricao", clienteServico.TipoServicoId);
            return View(clienteServico);
        }

        // GET: ClienteServicos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteServico clienteServico = db.ClienteServico.Find(id);
            if (clienteServico == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome", clienteServico.ClienteId);
            ViewBag.TipoServicoId = new SelectList(db.TipoServicoes, "Id", "Descricao", clienteServico.TipoServicoId);
            return View(clienteServico);
        }

        // POST: ClienteServicos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClienteServicoId,ClienteId,TipoServicoId")] ClienteServico clienteServico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteServico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(db.Clientes, "Id", "Nome", clienteServico.ClienteId);
            ViewBag.TipoServicoId = new SelectList(db.TipoServicoes, "Id", "Descricao", clienteServico.TipoServicoId);
            return View(clienteServico);
        }

        // GET: ClienteServicos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteServico clienteServico = db.ClienteServico.Find(id);
            if (clienteServico == null)
            {
                return HttpNotFound();
            }
            return View(clienteServico);
        }

        // POST: ClienteServicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClienteServico clienteServico = db.ClienteServico.Find(id);
            db.ClienteServico.Remove(clienteServico);
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
