using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Briefing.Models
{
    [Table("Endereco")]
    public class Endereco
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        [Column("Rua")]
        public string Rua { get; set; }

        [Column("Bairro")]
        public string Bairro { get; set; }

        [Column("Cep")]
        public string Cep { get; set; }

        [Column("IdCidade")]
        public int IdCidade { get; set; }

        [ForeignKey("IdCidade")]
        public Cidade Cidade { get; set; }

    }
}