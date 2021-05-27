using Briefing.Context;
using Briefing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Briefing.Dao
{
    public class EnderecosDao
    {
        private ContextModel db = new ContextModel();

        public List<Endereco> Lista()
        {
            return db.Enderecos.ToList();
        }
    }
}