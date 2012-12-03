using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemInventario
    {
        public ItemInventario()
        {
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int ItemInventarioId { get; set; }
        public Nullable<int> InventarioId { get; set; }
        public Nullable<int> ValorProdutoId { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public virtual Inventario Inventario { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
    }
}