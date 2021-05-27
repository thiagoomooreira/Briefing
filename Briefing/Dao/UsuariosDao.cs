using Briefing.Context;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briefing.Dao
{
    public class UsuariosDao
    {
        private ContextModel db = new ContextModel();

        public List<Usuario> Lista()
        {
            return db.Usuarios.ToList();
        }

        public Usuario VerificaLogin(Usuario usuario)
        {
            return db.Usuarios.Where(l => l.Email == usuario.Email && l.Senha == usuario.Senha).FirstOrDefault();
        }

        public void Adiciona(Usuario usuario)
        {
            db.Usuarios.Add(usuario);
            db.SaveChanges();
        }
    }
}