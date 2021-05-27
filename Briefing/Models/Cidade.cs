using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Briefing.Models
{
    [Table("Cidade")]
    public class Cidade
    {
        [Column("Id"), Key]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("EstadoNome")]
        public string EstadoNome { get; set; }

    }
}