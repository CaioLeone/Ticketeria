using ProjetoTicket.Models.Enuns;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoTicket.Models
{
    public class Assento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Descricao { get; set; }
        public AssentoStatus Status {get; set;}

        public ICollection<Sala> Salas { get; set; } = new List<Sala>();
    }
}
