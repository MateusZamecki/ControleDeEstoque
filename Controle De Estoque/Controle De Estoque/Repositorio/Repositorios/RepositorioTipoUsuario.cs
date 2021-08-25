using Controle_De_Estoque.Models;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interfaces
{
    public class RepositorioTipoUsuario : RepositorioBase<TipoUsuario>, IRepositorioTipoUsuario
    {
        public RepositorioTipoUsuario(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
