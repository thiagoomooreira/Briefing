using Briefing.Context;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Briefing.Dao
{
    public class CidadesDao
    {
        private ContextModel db = new ContextModel();

        public List<Cidade> Lista()
        {
            return db.Cidades.ToList();
        }

        public Cidade Busca(int id)
        {
            return db.Cidades.Find(id);
        }

        public void Adiciona(Cidade cidade)
        {
            db.Cidades.Add(cidade);
            db.SaveChanges();
        }

        public void Edita(Cidade cidade)
        {
            db.Entry(cidade).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Deleta(Cidade cidade)
        {
            db.Cidades.Remove(cidade);
            db.SaveChanges();
        }
    }
}