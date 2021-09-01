using System;

namespace Controle_De_Estoque.Models
{
    public class Cliente : Usuario
    {
        public DateTime DataCadastro { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
