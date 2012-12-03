using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ItemKit
    {
        public int ItemKitId { get; set; }
        public Nullable<int> KitId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<decimal> PercentualCusto { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public virtual Kit Kit { get; set; }
        public virtual Produto Produto { get; set; }
    }
}