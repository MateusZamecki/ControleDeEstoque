﻿using Controle_De_Estoque.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoIntegradorMVC.Models.Repositorio;
using System.Collections.Generic;

namespace Controle_De_Estoque.Controllers
{
    public class ClienteController : Controller
    {
        private ProdutoService oProdutoService = new();
        private CategoriaService oCategoriaService = new();
        private FornecedorService oFornecedorService = new();
        private VendaService oVendaService = new();
        private ClienteService oClienteService = new();

        public IActionResult PrincipalCliente()
        {
            List<Produto> produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            return View(produtos);
        }
        public IActionResult AdicionarAoCarrinho()
        {
            var produtos = oProdutoService.oRepositorioProduto.SelecionarTodos();
            return View(produtos);
        }
    }
}