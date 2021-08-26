using Controle_De_Estoque.DAL;
using Controle_De_Estoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProjetoIntegradorMVC.Models.Repositorio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_De_Estoque.Controllers
{
    public class HomeController : Controller
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        public IActionResult Principal()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            foreach (var produto in produtos) 
            {
                var categoriaProduto = oCategoriaService.oRepositorioCategoria.SelecionarPorId(produto.CategoriaId);
                var fornecedorProduto = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(produto.FornecedorId);
                produto.AdicionarCategoria(categoriaProduto);
                produto.AdicionarFornecedor(fornecedorProduto);
            }
            return View(produtos);
        }
        public IActionResult Create()
        {
            var categorias = oCategoriaService.oRepositorioCategoria.SelecionarTodos();
            var fornecedores = oFornecedorService.oRepositorioFornecedor.SelecionarTodos();
            ViewBag.CategoriaId = new SelectList(categorias, "Id","Nome");
            ViewBag.FornecedorId = new SelectList(fornecedores, "Id", "Nome");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            produto.ValorCompra /= 100;
            produto.ValorVenda /= 100;
            oProdutoService.oRepositorioProduto.Incluir(produto);
            return View();
        }
    }
}
