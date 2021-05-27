using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Briefing.Context
{
    public class ContextModel : DbContext
    {

        public ContextModel() :base("dbBriefing"){ }

        public virtual DbSet<Aluno> Alunos { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}