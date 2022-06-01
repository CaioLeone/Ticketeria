using Microsoft.EntityFrameworkCore;
using ProjetoTicket.Models;

namespace ProjetoTicket.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options) {

        }

        public DbSet<Evento>? Eventos { get; set; }
        public DbSet<Local>? Locals { get; set;}
        public DbSet<Sala>? Salas { get; set;}
        public DbSet<Assento>? Assentos { get; set;}
        public DbSet<Categoria>? Categorias { get; set; }
    }
}
