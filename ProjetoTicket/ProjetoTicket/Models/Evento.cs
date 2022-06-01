using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProjetoTicket.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Descricao { get; set; }
        public DateTime? Datas { get; set; }
        public ICollection<Local> Locais { get; set; } = new List<Local>();
        public Categoria? Categorias { get; set; }
    }
}
