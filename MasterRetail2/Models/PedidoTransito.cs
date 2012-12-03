using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class PedidoTransito
    {
        public int PedidoTransitoId { get; set; }
        public Nullable<int> EntradaId { get; set; }
        public Nullable<int> ValorProdutoId { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<int> ItemEntradaId { get; set; }
        public virtual ItemEntrada ItemEntrada { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
    }
}