using System.Collections.Generic;
using System.Linq;
using AgendaAspNetCore.Models;

namespace AgendaAspNetCore.Services
{
    public static class TelefoneService
    {
        public static List<Telefone> GetAll()
        {
            using (var db = new DatabaseContext())
            {
                return db.Telefones.ToList();   
            }
        }

        public static Telefone Get(int id)
        {
            using (var db = new DatabaseContext())
            {
                return db.Telefones.Where(p => p.Id == id).FirstOrDefault();
            }
        }

        public static void Add(Telefone t)
        {
            using (var db = new DatabaseContext())
            {
                db.Telefones.Add(t);
                db.SaveChanges();
            }
        }

        public static Telefone Delete(int id)
        {
            Telefone t = Get(id);
            
            if (t != null)
            {
                using (var db = new DatabaseContext())
                {
                    db.Telefones.Remove(t);
                }
            }
            
            return t;
        }

        public static Telefone Update(int id, Telefone telefone)
        {
            Telefone t = Get(id);
            
            if (t != null)
            {
                using (var db = new DatabaseContext())
                {
                    t.Numero = telefone.Numero;
                    t.Descricao = telefone.Descricao;
                    db.Telefones.Update(t);
                    db.SaveChanges();
                }
            }
            
            return t;
        }
    }
}
