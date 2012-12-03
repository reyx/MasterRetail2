using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class EnderecoPessoa
	{
	    public EnderecoPessoa()
		{
			this.NotasFiscais = new List<NotaFiscal>();
			this.PedidosVenda = new List<PedidoVenda>();
			this.Vendas = new List<Venda>();
			this.Entradas = new List<Entrada>();
			this.NotasFiscais1 = new List<NotaFiscal>();
			this.PedidosCompra = new List<PedidoCompra>();
			this.PedidosVenda1 = new List<PedidoVenda>();
			this.Vendas1 = new List<Venda>();
			this.Entradas1 = new List<Entrada>();
			this.PedidosCompra2 = new List<PedidoCompra>();
			this.Entradas2 = new List<Entrada>();
			this.NotasFiscais2 = new List<NotaFiscal>();
			this.PedidosCompra2 = new List<PedidoCompra>();
			this.PedidosVenda2 = new List<PedidoVenda>();
			this.Vendas2 = new List<Venda>();
			this.Entradas3 = new List<Entrada>();
			this.NotasFiscais3 = new List<NotaFiscal>();
			this.PedidosCompra3 = new List<PedidoCompra>();
			this.PedidosVenda3 = new List<PedidoVenda>();
			this.Vendas3 = new List<Venda>();
			this.Entradas4 = new List<Entrada>();
			this.NotasFiscais4 = new List<NotaFiscal>();
			this.PedidosCompra4 = new List<PedidoCompra>();
			this.PedidosVenda4 = new List<PedidoVenda>();
			this.Vendas4 = new List<Venda>();
		}

        public int EnderecoPessoaId { get; set; }
		public Nullable<int> PessoaId { get; set; }
		public Nullable<int> TipoEnderecoId { get; set; }
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Bairro { get; set; }
		public string Cidade { get; set; }
		public Nullable<decimal> CodigoIbgeCidade { get; set; }
		public string Uf { get; set; }
        public Nullable<decimal> CodigoIbgeUf { get; set; }
		public string Cep { get; set; }
		public string PadraoString { get; set; }
        public bool Padrao
        {
            get { return PadraoString == "A"; }
            set { PadraoString = value ? "A" : "B"; }
        }
		public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
		public virtual ICollection<Venda> Vendas { get; set; }
		public virtual ICollection<Entrada> Entradas { get; set; }
		public virtual ICollection<NotaFiscal> NotasFiscais1 { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda1 { get; set; }
		public virtual ICollection<Venda> Vendas1 { get; set; }
		public virtual ICollection<Entrada> Entradas1 { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra1 { get; set; }
		public virtual ICollection<Entrada> Entradas2 { get; set; }
		public virtual ICollection<NotaFiscal> NotasFiscais2 { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra2 { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda2 { get; set; }
		public virtual ICollection<Venda> Vendas2 { get; set; }
		public virtual ICollection<Entrada> Entradas3 { get; set; }
		public virtual ICollection<NotaFiscal> NotasFiscais3 { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra3 { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda3 { get; set; }
		public virtual ICollection<Venda> Vendas3 { get; set; }
		public virtual ICollection<Entrada> Entradas4 { get; set; }
		public virtual ICollection<NotaFiscal> NotasFiscais4 { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra4 { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda4 { get; set; }
		public virtual ICollection<Venda> Vendas4 { get; set; }
		public virtual Pessoa Pessoa { get; set; }
        public virtual TipoEndereco TipoEndereco { get; set; }
	}
}

