using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Briefing.Models
{
    [Table("Pais")]
    public class Pais
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Cpf")]
        public string Cpf { get; set; }

        [Column("Rg")]
        public string Rg { get; set; }

        [Column("Profissao")]
        public string Profissao { get; set; }

        [Column("Celular")]
        public string Celular { get; set; }

        [Column("DataCadastro")]
        public DateTime DataCadastro { get; set; }
    }
}