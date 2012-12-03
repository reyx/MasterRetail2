using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Comissao
	{
        public int ComissaoId { get; set; }
		public string Status { get; set; }
		public Nullable<System.DateTime> Faturamento{ get; set; }
		public Nullable<System.DateTime> Vencimento{ get; set; }
		public string Numero{ get; set; }
		public string Letra{ get; set; }
		public Nullable<decimal> ValorPago{ get; set; }
		public Nullable<decimal> Valor{ get; set; }
		public string Tipo{ get; set; }
		public Nullable<int> ClienteId{ get; set; }
		public Nullable<int> VendedorId { get; set; }
		public Nullable<int> CondicaoPagamentoId { get; set; }
		public Nullable<int> Parcela{ get; set; }
		public virtual Cliente Cliente { get; set; }
		public virtual CondicaoPagamento CondicaoPagamento { get; set; }
		public virtual Vendedor Vendedor { get; set; }
	}
}

