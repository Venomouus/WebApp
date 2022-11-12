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

        public ClienteModel BuscarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }


        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = BuscarPorId(cliente.Id);

            if (clienteDB == null) throw new System.Exception("Houve um erro");

            clienteDB.Nm_Empresa = cliente.Nm_Empresa;
            clienteDB.Cd_Empresa = cliente.Cd_Empresa;
            clienteDB.Ds_Cnpj = cliente.Ds_Cnpj;
            clienteDB.Nr_Total_Onibus = cliente.Nr_Total_Onibus;
            clienteDB.Data_Cadastro = cliente.Data_Cadastro;

            _context.Clientes.Update(clienteDB);
            _context.SaveChanges();

            return clienteDB;
        }
        public bool Apagar(int id)
        {
            ClienteModel clienteDB = BuscarPorId(id);

            if (clienteDB == null) throw new System.Exception("Houve um erro");

            _context.Clientes.Remove(clienteDB);
            _context.SaveChanges();

            return true;
        }




    }
}