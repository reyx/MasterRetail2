using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Indicacao
    {
        public Indicacao()
        {
            this.Clientes = new List<Cliente>();
        }

        public int IndicacaoId { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}