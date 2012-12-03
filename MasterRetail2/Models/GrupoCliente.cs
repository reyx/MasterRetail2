using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class GrupoCliente
    {
        public GrupoCliente()
        {
            this.Clientes = new List<Cliente>();
        }

        public int GrupoClienteId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}