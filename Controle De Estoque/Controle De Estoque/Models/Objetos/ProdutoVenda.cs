using System;

namespace Controle_De_Estoque.Models
{
    public class ProdutoVenda
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
    }
}
