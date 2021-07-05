using System.Collections.Generic;
using System.Linq;
using AgendaAspNetCore.Dto;
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

        public static Endereco Add(CreateEndereco ce)
        {
            var e = ce.Create();

            using (var db = new DatabaseContext())
            {
                db.Enderecos.Add(e);
                db.SaveChanges();
                return e;
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
                    db.SaveChanges();
                }
            }
            
            return e;
        }

        public static Endereco Update(int id, UpdateEndereco ue)
        {
            Endereco e = Get(id);
            
            if (e != null)
            {
                e = ue.Update(e);

                using (var db = new DatabaseContext())
                {
                    db.Enderecos.Update(e);
                    db.SaveChanges();
                }
            }
            
            return e;
        }
    }
}
