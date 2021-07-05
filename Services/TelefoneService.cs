using System.Collections.Generic;
using System.Linq;
using AgendaAspNetCore.Dto;
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

        public static Telefone Add(CreateTelefone ct)
        {
            var t = ct.Create();

            using (var db = new DatabaseContext())
            {
                db.Telefones.Add(t);
                db.SaveChanges();
                return t;
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
                    db.SaveChanges();
                }
            }
            
            return t;
        }

        public static Telefone Update(int id, UpdateTelefone ut)
        {
            Telefone t = Get(id);
            
            if (t != null)
            {
                t = ut.Update(t);

                using (var db = new DatabaseContext())
                {
                    db.Telefones.Update(t);
                    db.SaveChanges();
                }
            }
            
            return t;
        }
    }
}
