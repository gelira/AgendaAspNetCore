using System.ComponentModel.DataAnnotations;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Dto
{
    public class CreateEndereco
    {   
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        [RegularExpression(@"^\d{8}$")]
        public string CEP { get; set; }

        [Required]
        public int PessoaId { get; set; }

        public Endereco Create()
        {
            if (Complemento is null)
            {
                Complemento = "";
            }

            return new Endereco
            {
                Logradouro = Logradouro,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                Cidade = Cidade,
                Estado = Estado,
                CEP = CEP,
                PessoaId = PessoaId
            };
        }
    }
}
