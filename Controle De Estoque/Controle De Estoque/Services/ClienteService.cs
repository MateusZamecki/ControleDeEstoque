using Controle_De_Estoque.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorMVC.Models.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorMVC.Models.Repositorio
{
    public class ClienteService
    {
        public RepositorioCliente oRepositorioCliente { get; set; }            
        public ClienteService()
        {
            oRepositorioCliente = new();
        }
    }
}