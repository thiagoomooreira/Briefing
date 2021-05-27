using Briefing.Context;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Briefing.Dao
{
    public class AlunosDao
    {
        private ContextModel db = new ContextModel();

        public void Adiciona(Aluno aluno)
        {
            db.Alunos.Add(aluno);
            db.SaveChanges();
        }

        public List<Aluno> Lista()
        {
            return db.Alunos.Include("Endereco.Cidade").ToList();
        }

        public Aluno Busca(int id) {
            return db.Alunos
                .Include("Endereco.Cidade")
                .Include("Pai")
                .Include("Mae")
                .Where(l=>l.Id == id).FirstOrDefault();
        }

        public List<Aluno> ListaPelaCidade(int idCidade)
        {
            return db.Alunos.Where(l => l.Endereco.IdCidade == idCidade).ToList();
        }

        public void Edita(Aluno aluno)
        {
            db.Entry(aluno).State = EntityState.Modified;
            db.Entry(aluno.Endereco).State = EntityState.Modified;
            db.Entry(aluno.Pai).State = EntityState.Modified;
            db.Entry(aluno.Mae).State = EntityState.Modified;

            db.SaveChanges();
        }

        public void Deleta(int id)
        {
            Aluno aluno = db.Alunos.Find(id);
            Endereco endereco = db.Enderecos.Find(aluno.IdEndereco);
            Pais pai = db.Pais.Find(aluno.IdPai);
            Pais mae = db.Pais.Find(aluno.IdMae);

            db.Enderecos.Remove(endereco);
            db.Pais.Remove(pai);
            db.Pais.Remove(mae);
            db.Alunos.Remove(aluno);
            db.SaveChanges();
        }
    }
}