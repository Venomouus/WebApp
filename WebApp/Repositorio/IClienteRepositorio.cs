using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Repositorio
{
    public interface IClienteRepositorio
    {
        ClienteModel ListarPorId(int id);

        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);

        bool Apagar(int id); 
    }
}