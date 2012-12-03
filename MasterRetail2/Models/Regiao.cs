using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Regiao
    {
        public Regiao()
        {
            this.Clientes = new List<Cliente>();
        }

        public int RegiaoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}

