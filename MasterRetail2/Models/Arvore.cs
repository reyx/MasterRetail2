using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class Arvore
	{
        public Arvore()
		{
            this.ItensArvore = new List<ItemArvore>();
		}

		public int ArvoreId { get; set; }
		public Nullable<int> ProdutoId { get; set; }
		public Nullable<decimal> Lote { get; set; }
		public string Observacao { get; set; }
        public virtual ICollection<ItemArvore> ItensArvore { get; set; }
        public virtual Produto Produto { get; set; }
	}
}

