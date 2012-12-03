using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class FornecedorProduto
	{
        public int FornecedorProdutoId { get; set; }
		public Nullable<int> FornecedorId { get; set; }
		public Nullable<int> ProdutoId { get; set; }
		public Nullable<int> Codigo { get; set; }
		public virtual Fornecedor Fornecedor { get; set; }
		public virtual Produto Produto { get; set; }
	}
}