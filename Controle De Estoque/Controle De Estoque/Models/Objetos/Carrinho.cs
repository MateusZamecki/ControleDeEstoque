using ProjetoIntegradorMVC.Models.Repositorio;
using System;
using System.Collections.Generic;

namespace Controle_De_Estoque.Models
{
    public class Carrinho
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime DataHoraItem { get; set; }
        public List<ItemCarrinho> ProdutosCarrinho { get; set; } = new();
        private ItemCarrinhoService oItemCarrinhoService;
        public void PreencherItensCarrinho()
        {
            oItemCarrinhoService = new();
            ProdutosCarrinho.AddRange(oItemCarrinhoService.oRepositorioItemCarrinho.SelecionarTodos());
        }
    }
}
