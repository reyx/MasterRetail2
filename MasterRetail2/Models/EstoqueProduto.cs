using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class EstoqueProduto
	{
        public int EstoqueProdutoId { get; set; }
		public Nullable<int> LocalEstoqueId { get; set; }
		public Nullable<int> ValorPropriedadeId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<decimal> Extoque { get; set; }
		public virtual LocalEstoque LocalEstoque { get; set; }
		public virtual Loja Loja { get; set; }
		public virtual ValorProduto ValorProduto { get; set; }
	}
}