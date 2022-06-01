using System.ComponentModel.DataAnnotations;

namespace ProjetoTicket.Models.Enuns
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string? Nome { get; set; }
    }
}
