using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Briefing.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("Senha")]
        public string Senha { get; set; }

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

        [Column("IdEndereco")]
        public int IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public Endereco Endereco { get; set; }
    }
}