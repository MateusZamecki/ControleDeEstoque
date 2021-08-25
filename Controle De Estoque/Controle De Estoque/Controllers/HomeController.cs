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
        public IActionResult Index()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();            
            return View(produtos);
        }
    }
}
