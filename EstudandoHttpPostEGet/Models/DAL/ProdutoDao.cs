using System.Data;
using System.Data.SqlClient;

namespace EstudandoHttpPostEGet.Models.DAL
{
    public class ProdutoDao
    { 
        public DataTable ObterTodos()
        {
            var conexao = new Conexao().ObterConnectionString();
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                var queryString = "SELECT * FROM produto";
                var command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                var adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                var tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
        }
    }
}