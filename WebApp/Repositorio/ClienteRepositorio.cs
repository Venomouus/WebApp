using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _context;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPorId(id);

            if (clienteDB == null) throw new System.Exception("Houve um erro");

            _context.Clientes.Remove(clienteDB);
            _context.SaveChanges();

            return true;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPorId(cliente.Id);

            if (clienteDB == null) throw new System.Exception("Houve um erro");

            clienteDB.Nm_Empresa = cliente.Nm_Empresa;
            clienteDB.Cd_Empresa = cliente.Cd_Empresa;

            _context.Clientes.Update(clienteDB);
            _context.SaveChanges();

            return clienteDB;
        }


        public ClienteModel ListarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }
    }
}