using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MicrosoftIdentity.Models;
using Microsoft.AspNet.Identity;
using System.IO;

namespace MicrosoftIdentity.Controllers
{
   
    public class ProdutoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Produtoes
       
        public ActionResult Index()
        {
            if (Session["idCompra"] != null)
            {
                int auxIdCompra = int.Parse(Session["idCompra"].ToString());
                    

                ICollection<CompraProduto> x = db.ComprasProduto.Where(i=>i.IDCompra == auxIdCompra).ToList();
                ViewBag.ListaProdutosNaCompra = x;
            }
            return View(db.Produto.ToList());
        }

        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {

            if (Session["idCompra"] != null)
            {
                // compra em curso
                // vou adicionar o produto À compra existente


                var idProduto = collection["idProduto"];
                var quantidade = collection["quantidade"];
                var idCompra = Session["idCompra"].ToString();

                CompraProduto cp = new CompraProduto();
                cp.IDCompra = Int32.Parse(idCompra);
                cp.IDProduto = Int32.Parse(idProduto);
                cp.Quantidade = Int32.Parse(quantidade);

                db.ComprasProduto.Add(cp);
                db.SaveChanges();

              
                    int auxIdCompra = int.Parse(Session["idCompra"].ToString());
                    ICollection<CompraProduto> x = db.ComprasProduto.Where(i => i.IDCompra == auxIdCompra ).ToList();
                    ViewBag.ListaProdutosNaCompra = x;
               

            }
            else
            {
                // vou criar uma compra
                Compra c = new Compra();
                c.DataDaCompra = DateTime.Now;
                c.ApplicationUser = db.Users.Find(User.Identity.GetUserId());

                db.Compra.Add(c);
                db.SaveChanges();
                // vou adicionar o produto seleccionado à compra

                var idProduto = collection["idProduto"];
                var quantidade = collection["quantidade"];
                var idCompra = c.IDCompra;

                CompraProduto cp = new CompraProduto();
                cp.IDCompra = idCompra;
                cp.IDProduto = Int32.Parse(idProduto);
                cp.Quantidade = Int32.Parse(quantidade);

                db.ComprasProduto.Add(cp);
                db.SaveChanges();

                // vou definir a variavel de sessão com o id da compra
                Session["idCompra"] = c.IDCompra;

                int auxIdCompra = int.Parse(Session["idCompra"].ToString());
                ICollection<CompraProduto> x = db.ComprasProduto.Where(i => i.IDCompra == auxIdCompra).ToList();
                ViewBag.ListaProdutosNaCompra = x;


            }




            return View(db.Produto.ToList());
        }


        // GET: Produtoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produtoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produtoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDProduto,Nome,Preco")] Produto produto)
        {
            if (ModelState.IsValid)
            {                

                if (db.Produto.Where(i=>i.Nome== produto.Nome) != null)
                {
                    ViewBag.ErrorMessage = "Já existe um produto com este nome!";
                    return View();
                }
                else
                {
                    db.Produto.Add(produto);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }


                
            }

            return View(produto);
        }

        // GET: Produtoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "IDProduto,Nome,Preco")] Produto produto, 
            IEnumerable<HttpPostedFileBase> files
            )
        {
            if (ModelState.IsValid)
            {
                
                

                string nomeDoFicheiroAguardar = "P_" + produto.IDProduto.ToString() ;

                foreach (var file in files)
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        nomeDoFicheiroAguardar += Path.GetExtension(file.FileName);
                        file.SaveAs(Path.Combine(Server.MapPath("~/uploads"), nomeDoFicheiroAguardar));
                        produto.imagem = nomeDoFicheiroAguardar;

                    }
                }

                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(produto);
        }

        // GET: Produtoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.Produto.Find(id);
            db.Produto.Remove(produto);
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
