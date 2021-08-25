using System;

namespace Controle_De_Estoque.Models
{
    public class Acesso
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataLogin { get; set; }
    }
}
