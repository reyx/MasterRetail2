using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Transportador
    {
        public Transportador()
        {
            this.Clientes = new List<Cliente>();
            this.Entradas = new List<Entrada>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.PedidosCompra = new List<PedidoCompra>();
            this.PedidosVenda = new List<PedidoVenda>();
            this.Veiculos = new List<Veiculo>();
            this.Vendas = new List<Venda>();
        }

        public int TransportadorId { get; set; }
        public string AtivoString { get; set; }
		public bool Ativo
		{
			get { return AtivoString == "A"; }
			set { AtivoString = value ? "A" : "B"; }
		}
        public Nullable<int> PessoaId { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
        public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<Veiculo> Veiculos { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}