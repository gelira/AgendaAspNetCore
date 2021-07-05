using System.Collections.Generic;
using System.Linq;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Services
{
    public static class EnderecoService
    {
        public static List<Endereco> GetAll()
        {
            using (var db = new DatabaseContext())
            {
                return db.Enderecos.ToList();   
            }
        }

        public static Endereco Get(int id)
        {
            using (var db = new DatabaseContext())
            {
                return db.Enderecos.Where(e => e.Id == id).FirstOrDefault();
            }
        }

        public static void Add(Endereco e)
        {
            using (var db = new DatabaseContext())
            {
                db.Enderecos.Add(e);
                db.SaveChanges();
            }
        }

        public static Endereco Delete(int id)
        {
            Endereco e = Get(id);
            
            if (e != null)
            {
                using (var db = new DatabaseContext())
                {
                    db.Enderecos.Remove(e);
                }
            }
            
            return e;
        }

        public static Endereco Update(int id, Endereco endereco)
        {
            Endereco e = Get(id);
            
            if (e != null)
            {
                using (var db = new DatabaseContext())
                {
                    e.Logradouro = endereco.Logradouro;
                    e.Numero = endereco.Numero;
                    e.Complemento = endereco.Complemento;
                    e.Bairro = endereco.Bairro;
                    e.Cidade = endereco.Cidade;
                    e.Estado = endereco.Estado;
                    e.CEP = endereco.CEP;
                    
                    db.Enderecos.Update(e);
                    db.SaveChanges();
                }
            }
            
            return e;
        }
    }
}
