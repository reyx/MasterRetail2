using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemPromocao
    {
        public int ItemPromocaoId { get; set; }
        public Nullable<int> PromocaoId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Promocao Promocao { get; set; }
    }
}