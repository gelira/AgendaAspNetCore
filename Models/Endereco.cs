using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AgendaAspNetCore.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [MaxLength(10)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        [RegularExpression(@"^\d{8}$")]
        public string CEP { get; set; }

        public int PessoaId { get; set; }

        [ForeignKey("PessoaId")]
        [JsonIgnore]
        public Pessoa Pessoa { get; set; }
    }
}
