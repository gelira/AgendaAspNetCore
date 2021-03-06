using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
        [MaxLength(20)]
        public string Numero { get; set; }

        public int PessoaId { get; set; }

        [ForeignKey("PessoaId")]
        [JsonIgnore]
        public Pessoa Pessoa { get; set; }
    }
}
