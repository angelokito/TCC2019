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
    public class ClientesController : Controller
    {
        private PrimeiroAspTccContext db = new PrimeiroAspTccContext();

        // GET: Clientes
        public ActionResult Index()
        {
            if (!this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("Cookie"))
            {
                return RedirectToAction("Login", "Clientes");
            }

            HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["Cookie"];

            ViewBag.Username = cookie.Value;
            return View(db.Clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int? id, int? tiposervicoid )
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (tiposervicoid != null)
            {
                ClienteServico clserv = new ClienteServico();
                clserv.ClienteId = id.Value;
                clserv.TipoServicoId = tiposervicoid.Value;
                db.ClienteServico.Add(clserv);
                db.SaveChanges();
            }

            Cliente cliente = db.Clientes.Include(i => i.Servicos.Select(p=> p.TipoServico ))
                                        .SingleOrDefault(x => x.Id == id);
            if (cliente == null)
            {
                return HttpNotFound();
            }

            
            ViewBag.listaTipo = db.TipoServicoes.ToList();
            

            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Data_nasc,Email,Cpf,Rg,Sexo,Ender_resi,End_comercial,Cel,Login,Senha")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("BoasVindas");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Data_nasc,Email,Cpf,Rg,Sexo,Ender_resi,End_comercial,Cel,Login,Senha")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }


        [HttpGet]
        public ActionResult Login(string msg )
        {
            ViewBag.Msg = msg;
            return View();
        }

        [HttpPost]
        public ActionResult Login( string login, string senha )
        {
            Cliente cliente = db.Clientes.Where( a => a.Login == login && a.Senha == senha ).FirstOrDefault();
            if (cliente == null)
            {
                return RedirectToAction("Login", "Clientes", new { msg = "Usuário ou senha inválido!" } );
            }

            HttpCookie cookie = new HttpCookie("Cookie", cliente.Login);
            cookie.Expires = DateTime.Now.AddHours(1);
            cookie.HttpOnly = true;
            this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);

            return RedirectToAction("Index", "Clientes"); 
        }

        public ActionResult Logout()
        {
            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("Cookie"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["Cookie"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                this.ControllerContext.HttpContext.Response.Cookies.Add(cookie);
            }
            return RedirectToAction("Login", "Clientes");
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
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

        public ActionResult BoasVindas()
        {
            return View();
        }
    }
}
