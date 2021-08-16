using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstudandoHttpPostEGet
{
    [Table("Produto")]
    public class Produto
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }
        [Display(Name = "Preco")]
        [Column("Preco")]
        public decimal Preco { get; set; }
        [Display(Name = "CategoriaId")]
        [Column("CategoriaId")]
        public int CategoriaId { get; set; }

        public List<Produto> ObterTodos()
        {
        }
    }
}
