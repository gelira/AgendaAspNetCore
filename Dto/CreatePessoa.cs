using System.ComponentModel.DataAnnotations;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Dto
{
    public class CreatePessoa
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Nome { get; set; }

        public Pessoa Create()
        {
            return new Pessoa
            {
                Nome = Nome
            };
        }
    }
}
