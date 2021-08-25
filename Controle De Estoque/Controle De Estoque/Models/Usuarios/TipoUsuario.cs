using System;

namespace Controle_De_Estoque.Models
{
    public class TipoUsuario
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public bool EhFuncionario { get; set; }
    }
}
