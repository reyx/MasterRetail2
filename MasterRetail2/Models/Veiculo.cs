using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Veiculo
	{
        public Veiculo()
		{
			this.Entradas = new List<Entrada>();
			this.NotasFiscais = new List<NotaFiscal>();
			this.PedidosCompra = new List<PedidoCompra>();
			this.PedidosVenda = new List<PedidoVenda>();
		}

        public int VeiculoId { get; set; }
		public string Placa { get; set; }
		public Nullable<int> CidadeId { get; set; }
		public string Rntc { get; set; }
		public Nullable<int> TransportadorId { get; set; }
		public virtual ICollection<Entrada> Entradas { get; set; }
		public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
		public virtual Transportador Transportador { get; set; }
	}
}