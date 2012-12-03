using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Acessorio
	{
		public int AcessorioId { get; set; }
		public int ProdutoId { get; set; }
		public int ProdutoAcessorioId { get; set; }
		public Nullable<decimal> Quantidade{ get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Produto ProdutoAcessorio { get; set; }
	}
}