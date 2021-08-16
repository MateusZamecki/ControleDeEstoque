namespace EstudandoHttpPostEGet.Models.DAL
{
    public class Conexao
    {
        public string ObterConnectionString() => "Data Source=ZAMECKI\\SERVER;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}