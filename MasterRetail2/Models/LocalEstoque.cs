using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class LocalEstoque
    {
        public LocalEstoque()
        {
            this.EstoquesProduto = new List<EstoqueProduto>();
            this.EstoquesProdutoCubo = new List<EstoqueProdutoCubo>();
            this.Inventarios = new List<Inventario>();
            this.ItensEntrada = new List<ItemEntrada>();
            this.ItensMovimento = new List<ItemMovimento>();
            this.ItensMovimentoDestino = new List<ItemMovimento>();
            this.ItensNotaFiscal = new List<ItemNotaFiscal>();
            this.ItensPedidoCompra = new List<ItemPedidoCompra>();
            this.ItensPedidoVenda = new List<ItemPedidoVenda>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int LocalEstoqueId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<EstoqueProduto> EstoquesProduto { get; set; }
        public virtual ICollection<EstoqueProdutoCubo> EstoquesProdutoCubo { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<ItemEntrada> ItensEntrada { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimentoDestino { get; set; }
        public virtual ICollection<ItemNotaFiscal> ItensNotaFiscal { get; set; }
        public virtual ICollection<ItemPedidoCompra> ItensPedidoCompra { get; set; }
        public virtual ICollection<ItemPedidoVenda> ItensPedidoVenda { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
    }
}