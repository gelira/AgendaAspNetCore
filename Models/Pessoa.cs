using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AgendaAspNetCore.Models
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [JsonIgnore]
        public List<Endereco> Enderecos { get; set; }
        
        [JsonIgnore]
        public List<Telefone> Telefones { get; set; }
    }
}
