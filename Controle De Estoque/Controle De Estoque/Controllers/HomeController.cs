using Controle_De_Estoque.Models;
using Microsoft.AspNetCore.Mvc;
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
        private ProdutoService oProdutoService = new ProdutoService();
        private CategoriaService oCategoriaService = new CategoriaService();
        private FornecedorService oFornecedorService = new FornecedorService();
        public IActionResult Principal()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            foreach (var produto in produtos) 
            {
                var categoriaProduto = oCategoriaService.oRepositorioCategoria.SelecionarPorId(produto.CategoriaId);
                var fornecedorProduto = oFornecedorService.oRepositorioFornecedor.SelecionarPorId(produto.CategoriaId);
                produto.AdicionarCategoria(categoriaProduto);
                produto.AdicionarFornecedor(fornecedorProduto);
            }
            return View(produtos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            return View();
        }
    }
}
