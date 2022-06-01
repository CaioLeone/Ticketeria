using System.ComponentModel.DataAnnotations;

namespace ProjetoTicket.Models
{
    public class Local
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? Nome { get; set; }
    }
}
