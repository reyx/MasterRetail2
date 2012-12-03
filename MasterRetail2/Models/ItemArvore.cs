using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemArvore
    {
        public int ItemArvoreId { get; set; }
        public Nullable<int> ArvoreId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<decimal> PercentualCusto { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public virtual Arvore Arvore { get; set; }
        public virtual Produto Produto { get; set; }
    }
}