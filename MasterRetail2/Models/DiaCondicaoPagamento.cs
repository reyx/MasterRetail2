using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class DiaCondicaoPagamento
	{
        public int DiaCondicaoPagamentoId { get; set; }
		public Nullable<int> CondicaoPagamentoId { get; set; }
		public Nullable<int> Dias { get; set; }
		public virtual CondicaoPagamento CondicaoPagamento { get; set; }
	}
}

