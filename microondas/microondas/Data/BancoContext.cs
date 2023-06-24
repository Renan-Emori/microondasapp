using Microondas.Models;
using Microsoft.EntityFrameworkCore;

namespace Microondas.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PreDefinidoModel> PreDefinidoModel { get; set; }
    }
}
