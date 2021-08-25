using System;

namespace Controle_De_Estoque.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorCompra { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCompra { get; set; }
        public int CategoriaId { get; set; }
        public int FornecedorId { get; set; }
    }
}
