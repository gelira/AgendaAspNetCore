using System.Collections.Generic;
using System.Linq;
using AgendaAspNetCore.Dto;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Services
{
    public static class PessoaService
    {
        public static List<Pessoa> GetAll()
        {
            using (var db = new DatabaseContext())
            {
                return db.Pessoas.ToList();   
            }
        }

        public static Pessoa Get(int id)
        {
            using (var db = new DatabaseContext())
            {
                return db.Pessoas.Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public static Pessoa Add(CreatePessoa cp)
        {
            var p = cp.Create();

            using (var db = new DatabaseContext())
            {
                db.Pessoas.Add(p);
                db.SaveChanges();
                return p;
            }
        }

        public static Pessoa Delete(int id)
        {
            Pessoa p = Get(id);
            
            if (p != null)
            {
                using (var db = new DatabaseContext())
                {
                    db.Pessoas.Remove(p);
                    db.SaveChanges();
                }
            }
            
            return p;
        }

        public static Pessoa Update(int id, UpdatePessoa up)
        {
            Pessoa p = Get(id);
            
            if (p != null)
            {
                p = up.Update(p);

                using (var db = new DatabaseContext())
                {
                    db.Pessoas.Update(p);
                    db.SaveChanges();
                }
            }
            
            return p;
        }
    }
}
