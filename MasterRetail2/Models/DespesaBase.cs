using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class DespesaBase
	{
        public int DespesaBaseId { get; set; }
		public Nullable<int> TipoDespesaId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public string PadraoZero { get; set; }
		public Nullable<decimal> Margem{ get; set; }
		public Nullable<decimal> ValorPadrao{ get; set; }
		public virtual Loja Loja { get; set; }
		public virtual TipoDespesa TipoDespesa { get; set; }
	}
}