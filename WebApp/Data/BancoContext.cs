using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class BancoContext : DbContext

    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<ClienteModel> Clientes { get; set; }
        public DbSet<OnibusModel> Onibus { get; set; }
    }
}