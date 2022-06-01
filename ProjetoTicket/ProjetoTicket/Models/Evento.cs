using System.ComponentModel.DataAnnotations;

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
    }
}
