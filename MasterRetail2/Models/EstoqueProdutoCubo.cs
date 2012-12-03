using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class EstoqueProdutoCubo
    {
        public int EstoqueProdutoCuboId { get; set; }
        public Nullable<int> LocalEstoqueId { get; set; }
        public Nullable<int> ValorProdutoId { get; set; }
        public Nullable<decimal> Estoque { get; set; }
        public virtual LocalEstoque LocalEstoque { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
    }
}