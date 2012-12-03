using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Vendedor
    {
        public Vendedor()
        {
            this.Clientes = new List<Cliente>();
            this.Comissoes = new List<Comissao>();
            this.Entradas = new List<Entrada>();
            this.ItensEntrada = new List<ItemEntrada>();
            this.ItensNotaFiscal = new List<ItemNotaFiscal>();
            this.ItensPedidoCompra = new List<ItemPedidoCompra>();
            this.ItensPedidoVenda = new List<ItemPedidoVenda>();
            this.ItensVenda = new List<ItemVenda>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.PedidosCompra = new List<PedidoCompra>();
            this.PedidosVenda = new List<PedidoVenda>();
            this.Vendas = new List<Venda>();
        }

        public int VendedorId { get; set; }
        public string AtivoString { get; set; }
		public bool Ativo
		{
			get { return AtivoString == "A"; }
			set { AtivoString = value ? "A" : "B"; }
		}
        public Nullable<int> PessoaId { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Comissao> Comissoes { get; set; }
        public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual ICollection<ItemEntrada> ItensEntrada { get; set; }
        public virtual ICollection<ItemNotaFiscal> ItensNotaFiscal { get; set; }
        public virtual ICollection<ItemPedidoCompra> ItensPedidoCompra { get; set; }
        public virtual ICollection<ItemPedidoVenda> ItensPedidoVenda { get; set; }
        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
        public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}