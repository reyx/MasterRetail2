using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class EvolucaoCusto
    {
        public int EvolucaoCustoId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<decimal> Custo { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> ListaId { get; set; }
        public virtual Lista Lista { get; set; }
        public virtual Produto Produto { get; set; }
    }
}