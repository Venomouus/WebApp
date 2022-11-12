using System.Collections.Generic;
using System.Linq;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Repositorio
{
    public class OnibusRepositorio : IOnibusRepositorio
    {
        private readonly BancoContext _context;
        public OnibusRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }

        public OnibusModel BuscarPorId(int id)
        {
            return _context.Onibus.FirstOrDefault(x => x.Id == id);
        }


        public OnibusModel Adicionar(OnibusModel onibus)
        {
            _context.Onibus.Add(onibus);
            _context.SaveChanges();

            return onibus;
        }

        public OnibusModel Atualizar(OnibusModel onibus)
        {
            OnibusModel onibusDB = BuscarPorId(onibus.Id);

            if (onibusDB == null) throw new System.Exception("Houve um erro");

            onibusDB.Placa = onibus.Placa;
            onibusDB.NumRota = onibus.NumRota;
            onibusDB.NomRota = onibus.NomRota;
            onibusDB.NumEntradas = onibus.NumEntradas;
            onibusDB.NumSaida = onibus.NumSaida;

            _context.Onibus.Update(onibusDB);
            _context.SaveChanges();

            return onibusDB;
        }
        public bool Apagar(int id)
        {
            OnibusModel onibusDB = BuscarPorId(id);

            if (onibusDB == null) throw new System.Exception("Houve um erro");

            _context.Onibus.Remove(onibusDB);
            _context.SaveChanges();

            return true;
        }




    }
}