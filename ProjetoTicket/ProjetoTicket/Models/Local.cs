using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoTicket.Models
{
    public class Local
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? Nome { get; set; }
        
        public Evento? Eventos { get; set; }
        public ICollection<Sala> Salas { get; set; } = new List<Sala>();
    }
}
