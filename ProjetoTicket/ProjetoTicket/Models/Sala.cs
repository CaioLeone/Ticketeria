using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoTicket.Models
{
    public class Sala
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? Nome { get; set; }
        [StringLength(50)]
        public string? Descricao { get; set; }
        public int? Capacidade { get; set; }

        public Local? Locais { get; set; }
        public ICollection<Assento> Assentos { get; set; } = new List<Assento>();

    }
}
