using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class PropriedadeProduto
    {
        public int PropriedadeProdutoId { get; set; }
        public Nullable<int> PropriedadeId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<int> Ordem { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Propriedade Propriedade { get; set; }
    }
}