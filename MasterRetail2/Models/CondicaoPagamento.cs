using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class CondicaoPagamento
    {
        public CondicaoPagamento()
        {
            this.Comissoes = new List<Comissao>();
            this.DiasCondicaoPagamento = new List<DiaCondicaoPagamento>();
            this.Entradas = new List<Entrada>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.PedidosCompra = new List<PedidoCompra>();
            this.PedidosVenda = new List<PedidoVenda>();
            this.Vendas = new List<Venda>();
        }

        public int CondicaoPagamentoId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public Nullable<decimal> Taxa { get; set; }
        public Nullable<decimal> Tac { get; set; }
        public Nullable<decimal> Coeficiente { get; set; }
        public Nullable<int> Dia { get; set; }
        public Nullable<int> Parcelas { get; set; }
        public virtual ICollection<Comissao> Comissoes { get; set; }
        public virtual ICollection<DiaCondicaoPagamento> DiasCondicaoPagamento { get; set; }
        public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
        public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
    }
}