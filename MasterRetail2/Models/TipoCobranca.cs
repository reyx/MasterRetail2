using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TipoCobranca
    {
        public TipoCobranca()
        {
            this.ContasPagar = new List<ContaPagar>();
        }

        public int TipoCobrancaId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ContaPagar> ContasPagar { get; set; }
    }
}