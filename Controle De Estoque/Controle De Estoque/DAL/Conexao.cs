using System;

namespace Controle_De_Estoque.Models
{
    public class Conexao
    {
        public string ObterString() => "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ControleDeEstoque;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
