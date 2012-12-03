using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rcky.MasterRetail2.Models;
using MasterRetail2.Models;

namespace MasterRetail2.Controllers
{
    public class ProdutosController : Controller
    {
        private MasterRetail2Context context = new MasterRetail2Context();
        private MasterRetail2BaseContext baseContext = new MasterRetail2BaseContext();

        //
        // GET: /Produtos/

        public ViewResult Index()
        {
            return View(context.Produtos.Include(produto => produto.GrupoFaturamento).Include(produto => produto.Unidade).Include(produto => produto.Embalagem).Include(produto => produto.Fornecedor).Include(produto => produto.CodigoTributacao).Include(produto => produto.Promocao).Include(produto => produto.Servico).Include(produto => produto.Arvores).Include(produto => produto.Equipamentos).Include(produto => produto.EvolucoesCusto).Include(produto => produto.Fornecedores).Include(produto => produto.Fotos).Include(produto => produto.ItensArvore).Include(produto => produto.ItensKit).Include(produto => produto.ItensPromocao).Include(produto => produto.ItensTecladoRapido).Include(produto => produto.Listas).Include(produto => produto.Propriedades).Include(produto => produto.Acessorios).Include(produto => produto.TeclasMicroTerminal).Include(produto => produto.Valores).Include(produto => produto.Lojas).ToList());
        }

        //
        // GET: /Produtos/Details/5

        public ViewResult Details(int id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // GET: /Produtos/Create

        public ActionResult Create()
        {
            ViewBag.PossibleGrupoProdutos = context.GruposProdutos;
            ViewBag.PossibleGrupoFaturamentoes = context.GruposFaturamentos;
            ViewBag.PossibleUnidades = context.Unidades;
            ViewBag.PossibleEmbalagems = context.Unidades;
            ViewBag.PossibleFornecedores = context.Fornecedores;
            ViewBag.PossibleCodigoTributacaos = context.CodigoTributacoes;
            ViewBag.PossiblePromocaos = context.Promocoes;
            ViewBag.PossibleServicoes = context.Servicos;
            ViewBag.PossibleNcms = baseContext.Ncms;
            ViewBag.PossibleOrigemProdutos = baseContext.OrigensProdutos;
            ViewBag.PossibleModalidadeProdutos = baseContext.ModalidadesProdutos;
            return View();
        }

        //
        // POST: /Produtos/Create

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            if (ModelState.IsValid)
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PossibleGrupoProdutos = context.GruposProdutos;
            ViewBag.PossibleGrupoFaturamentoes = context.GruposFaturamentos;
            ViewBag.PossibleUnidades = context.Unidades;
            ViewBag.PossibleEmbalagems = context.Unidades;
            ViewBag.PossibleFornecedores = context.Fornecedores;
            ViewBag.PossibleCodigoTributacaos = context.CodigoTributacoes;
            ViewBag.PossiblePromocaos = context.Promocoes;
            ViewBag.PossibleServicoes = context.Servicos;
            ViewBag.PossibleNcms = baseContext.Ncms;
            ViewBag.PossibleOrigemProdutos = baseContext.OrigensProdutos;
            ViewBag.PossibleModalidadeProdutos = baseContext.ModalidadesProdutos;
            return View(produto);
        }

        //
        // GET: /Produtos/Edit/5

        public ActionResult Edit(int id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            ViewBag.PossibleGrupoProdutos = context.GruposProdutos;
            ViewBag.PossibleGrupoFaturamentoes = context.GruposFaturamentos;
            ViewBag.PossibleUnidades = context.Unidades;
            ViewBag.PossibleEmbalagems = context.Unidades;
            ViewBag.PossibleFornecedores = context.Fornecedores;
            ViewBag.PossibleCodigoTributacaos = context.CodigoTributacoes;
            ViewBag.PossiblePromocaos = context.Promocoes;
            ViewBag.PossibleServicoes = context.Servicos;
            ViewBag.PossibleNcms = baseContext.Ncms;
            ViewBag.PossibleOrigemProdutos = baseContext.OrigensProdutos;
            ViewBag.PossibleModalidadeProdutos = baseContext.ModalidadesProdutos;
            return View(produto);
        }

        //
        // POST: /Produtos/Edit/5

        [HttpPost]
        public ActionResult Edit(Produto produto)
        {
            if (ModelState.IsValid)
            {
                context.Entry(produto).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PossibleGrupoProdutos = context.GruposProdutos;
            ViewBag.PossibleGrupoFaturamentoes = context.GruposFaturamentos;
            ViewBag.PossibleUnidades = context.Unidades;
            ViewBag.PossibleEmbalagems = context.Unidades;
            ViewBag.PossibleFornecedores = context.Fornecedores;
            ViewBag.PossibleCodigoTributacaos = context.CodigoTributacoes;
            ViewBag.PossiblePromocaos = context.Promocoes;
            ViewBag.PossibleServicoes = context.Servicos;
            ViewBag.PossibleNcms = baseContext.Ncms;
            ViewBag.PossibleOrigemProdutos = baseContext.OrigensProdutos;
            ViewBag.PossibleModalidadeProdutos = baseContext.ModalidadesProdutos;
            return View(produto);
        }

        //
        // GET: /Produtos/Delete/5

        public ActionResult Delete(int id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            return View(produto);
        }

        //
        // POST: /Produtos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = context.Produtos.Single(x => x.ProdutoId == id);
            context.Produtos.Remove(produto);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}