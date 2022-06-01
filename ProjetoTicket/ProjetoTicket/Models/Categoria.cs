using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoTicket.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? Nome { get; set; }

        public ICollection<Evento> Eventos { get; set; } = new List<Evento>();
    }
}
