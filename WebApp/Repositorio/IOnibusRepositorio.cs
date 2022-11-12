using WebApp.Models;

namespace WebApp.Repositorio
{
    public interface IOnibusRepositorio
    {
        OnibusModel Adicionar(OnibusModel cliente);
      
        bool Apagar(int id);
        
        OnibusModel Atualizar(OnibusModel cliente);
       
        OnibusModel BuscarPorId(int id);
       
    }
}