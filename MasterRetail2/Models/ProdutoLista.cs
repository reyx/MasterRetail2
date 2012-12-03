using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ProdutoLista
    {
        public ProdutoLista()
        {
            this.ItensEntrada = new List<ItemEntrada>();
            this.ItensNotaFiscal = new List<ItemNotaFiscal>();
            this.ItensPedidoCompra = new List<ItemPedidoCompra>();
            this.ItensPedidoVenda = new List<ItemPedidoVenda>();
            this.ItensVenda = new List<ItemVenda>();
        }

        public int ProdutoListaId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<int> ListaId { get; set; }
        public Nullable<decimal> Custo { get; set; }
        public Nullable<decimal> Margem { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public virtual ICollection<ItemEntrada> ItensEntrada { get; set; }
        public virtual ICollection<ItemNotaFiscal> ItensNotaFiscal { get; set; }
        public virtual ICollection<ItemPedidoCompra> ItensPedidoCompra { get; set; }
        public virtual ICollection<ItemPedidoVenda> ItensPedidoVenda { get; set; }
        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
        public virtual Lista Lista { get; set; }
        public virtual Produto Produto { get; set; }
    }
}