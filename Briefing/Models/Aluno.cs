using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Briefing.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Cpf")]
        public string Cpf { get; set; }

        [Column("Sexo")]
        public string Sexo { get; set; }

        [Column("Telefone")]
        public string Telefone { get; set; }

        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [Column("Rg")]
        public string Rg { get; set; }

        [Column("DataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("Matricula")]
        public string Matricula { get; set; }

        [Column("Idade")]
        public int Idade { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("IdEndereco")]
        public int IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }

        [Column("IdPai")]
        public int IdPai { get; set; }

        [ForeignKey("IdPai")]
        public Pais Pai { get; set; }

        [Column("IdMae")]
        public int IdMae { get; set; }

        [ForeignKey("IdMae")]
        public Pais Mae { get; set; }
    }
}