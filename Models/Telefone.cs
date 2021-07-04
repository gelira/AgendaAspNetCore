using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaAspNetCore.Models
{
    [Table("Telefones")]
    public class Telefone
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required]
        [RegularExpression(@"^\d{10,11}$")]
        public string Numero { get; set; }

        public int PessoaId { get; set; }

        [ForeignKey("PessoaId")]
        public Pessoa Pessoa { get; set; }
    }
}
