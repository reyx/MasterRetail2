using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ValorProduto
    {
        public ValorProduto()
        {
            this.EstoquesProduto = new List<EstoqueProduto>();
            this.EstoquesProdutoCubo = new List<EstoqueProdutoCubo>();
            this.ItensEntrada = new List<ItemEntrada>();
            this.ItensInventario = new List<ItemInventario>();
            this.ItensMovimento = new List<ItemMovimento>();
            this.ItensNotaFiscal = new List<ItemNotaFiscal>();
            this.ItensPedidoCompra = new List<ItemPedidoCompra>();
            this.ItensPedidoVenda = new List<ItemPedidoVenda>();
            this.ItensVenda = new List<ItemVenda>();
            this.PedidosTransito = new List<PedidoTransito>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
            this.VendasProdutosCubo = new List<VendaProdutoCubo>();
        }

        public int ValorProdutoId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<int> ValorPropriedade1Id { get; set; }
        public Nullable<int> ValorPropriedade2Id { get; set; }
        public Nullable<int> ValorPropriedade3Id { get; set; }
        public virtual ICollection<EstoqueProduto> EstoquesProduto { get; set; }
        public virtual ICollection<EstoqueProdutoCubo> EstoquesProdutoCubo { get; set; }
        public virtual ICollection<ItemEntrada> ItensEntrada { get; set; }
        public virtual ICollection<ItemInventario> ItensInventario { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }
        public virtual ICollection<ItemNotaFiscal> ItensNotaFiscal { get; set; }
        public virtual ICollection<ItemPedidoCompra> ItensPedidoCompra { get; set; }
        public virtual ICollection<ItemPedidoVenda> ItensPedidoVenda { get; set; }
        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
        public virtual ICollection<PedidoTransito> PedidosTransito { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual ICollection<VendaProdutoCubo> VendasProdutosCubo { get; set; }
        public virtual ValorPropriedade ValorPropriedade1 { get; set; }
        public virtual ValorPropriedade ValorPropriedade2 { get; set; }
        public virtual ValorPropriedade ValorPropriedade3 { get; set; }
    }
}