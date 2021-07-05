using System.ComponentModel.DataAnnotations;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Dto
{
    public class UpdateEndereco
    {   
        [MinLength(1)]
        [MaxLength(100)]
        public string Logradouro { get; set; }

        [MinLength(1)]
        [MaxLength(10)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [StringLength(2)]
        public string Estado { get; set; }

        [MinLength(1)]
        [MaxLength(20)]
        [RegularExpression(@"^\d{8}$")]
        public string CEP { get; set; }

        public Endereco Update(Endereco e) 
        {
            if (Logradouro != null) 
            {
                e.Logradouro = Logradouro;
            }
            if (Numero != null) 
            {
                e.Numero = Numero;
            }
            if (Complemento != null) 
            {
                e.Complemento = Complemento;
            }
            if (Bairro != null) 
            {
                e.Bairro = Bairro;
            }
            if (Cidade != null) 
            {
                e.Cidade = Cidade;
            }
            if (Estado != null) 
            {
                e.Estado = Estado;
            }
            if (CEP != null) 
            {
                e.CEP = CEP;
            }
            return e;
        }
    }
}
