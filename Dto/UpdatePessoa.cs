using System.ComponentModel.DataAnnotations;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Dto
{
    public class UpdatePessoa
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string Nome { get; set; }

        public Pessoa Update(Pessoa p)
        {
            p.Nome = Nome;
            return p;
        }
    }
}
