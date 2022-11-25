using Microsoft.EntityFrameworkCore;
using pedidos.Entidades;

namespace pedidos
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
