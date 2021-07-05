using System.ComponentModel.DataAnnotations;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Dto
{
    public class CreateTelefone
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(20)]
        [RegularExpression(@"^\d{10,11}$")]
        public string Numero { get; set; }

        [Required]
        public int PessoaId { get; set; }

        public Telefone Create()
        {
            return new Telefone
            {
                Descricao = Descricao,
                Numero = Numero,
                PessoaId = PessoaId
            };
        }
    }
}
