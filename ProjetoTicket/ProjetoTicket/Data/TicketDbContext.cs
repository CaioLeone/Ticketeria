using Microsoft.EntityFrameworkCore;
using ProjetoTicket.Models;

namespace ProjetoTicket.Data
{
    public class TicketDbContext : DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options) { 
        
        }

        public DbSet<Evento>? Eventos { get; set; }
    }
}
