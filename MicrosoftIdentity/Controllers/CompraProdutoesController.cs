using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MicrosoftIdentity.Models;

namespace MicrosoftIdentity.Controllers
{
    public class CompraProdutoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CompraProdutoes
        public ActionResult Index()
        {
            var comprasProduto = db.ComprasProduto.Include(c => c.Compra).Include(c => c.Produto);
            return View(comprasProduto.ToList());
        }

        // GET: CompraProdutoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraProduto compraProduto = db.ComprasProduto.Find(id);
            if (compraProduto == null)
            {
                return HttpNotFound();
            }
            return View(compraProduto);
        }

        // GET: CompraProdutoes/Create
        public ActionResult Create()
        {
            ViewBag.IDCompra = new SelectList(db.Compra, "IDCompra", "IDCompra");
            ViewBag.IDProduto = new SelectList(db.Produto, "IDProduto", "Nome");
            return View();
        }

        // POST: CompraProdutoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDCompraProduto,IDCompra,IDProduto,Quantidade")] CompraProduto compraProduto)
        {
            if (ModelState.IsValid)
            {
                db.ComprasProduto.Add(compraProduto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDCompra = new SelectList(db.Compra, "IDCompra", "IDCompra", compraProduto.IDCompra);
            ViewBag.IDProduto = new SelectList(db.Produto, "IDProduto", "Nome", compraProduto.IDProduto);
            return View(compraProduto);
        }

        // GET: CompraProdutoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraProduto compraProduto = db.ComprasProduto.Find(id);
            if (compraProduto == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDCompra = new SelectList(db.Compra, "IDCompra", "IDCompra", compraProduto.IDCompra);
            ViewBag.IDProduto = new SelectList(db.Produto, "IDProduto", "Nome", compraProduto.IDProduto);
            return View(compraProduto);
        }

        // POST: CompraProdutoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDCompraProduto,IDCompra,IDProduto,Quantidade")] CompraProduto compraProduto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(compraProduto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCompra = new SelectList(db.Compra, "IDCompra", "IDCompra", compraProduto.IDCompra);
            ViewBag.IDProduto = new SelectList(db.Produto, "IDProduto", "Nome", compraProduto.IDProduto);
            return View(compraProduto);
        }

        // GET: CompraProdutoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompraProduto compraProduto = db.ComprasProduto.Find(id);
            if (compraProduto == null)
            {
                return HttpNotFound();
            }
            return View(compraProduto);
        }

        // POST: CompraProdutoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CompraProduto compraProduto = db.ComprasProduto.Find(id);
            db.ComprasProduto.Remove(compraProduto);
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
