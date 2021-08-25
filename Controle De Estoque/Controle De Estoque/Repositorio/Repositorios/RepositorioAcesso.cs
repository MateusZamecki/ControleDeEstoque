using Controle_De_Estoque.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioAcesso : RepositorioBase<Acesso>, IRepositorioAcesso
    {
        public RepositorioAcesso(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
