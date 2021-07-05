using System.ComponentModel.DataAnnotations;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Dto
{
    public class UpdateTelefone
    {
        [MinLength(1)]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        [RegularExpression(@"^\d{10,11}$")]
        public string Numero { get; set; }

        public Telefone Update(Telefone t)
        {
            if (Descricao != null)
            {
                t.Descricao = Descricao;
            }
            if (Numero != null) 
            {
                t.Numero = Numero;
            }
            return t;
        }
    }
}
