using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.Comissoes = new List<Comissao>();
            this.ContatosCliente = new List<ContatoCliente>();
            this.ContasReceber = new List<ContaReceber>();
            this.Equipamentos = new List<Equipamento>();
            this.LojasCliente = new List<LojaCliente>();
            this.MovimentacoesEquipamento = new List<MovimentacaoEquipamento>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.PedidosVenda = new List<PedidoVenda>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
            this.Vendas = new List<Venda>();
        }

        public int ClienteId { get; set; }
        public Nullable<int> TransportadorId { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> RegiaoId { get; set; }
        public Nullable<int> GrupoClienteId { get; set; }
        public Nullable<int> SituacaoId { get; set; }
        public Nullable<int> IndicacaoId { get; set; }
        public Nullable<int> ListaId { get; set; }
        public Nullable<int> PessoaId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ClienteLojaId { get; set; }
        public string AtivoString { get; set; }
		public bool Ativo
		{
			get { return AtivoString == "A"; }
			set { AtivoString = value ? "A" : "B"; }
		}
        public Nullable<System.DateTime> Cadastro { get; set; }
        public Nullable<System.DateTime> UltimaVisita { get; set; }
        public string Interesse { get; set; }
        public Nullable<decimal> Credito { get; set; }
        public Nullable<decimal> TaxaEntrega { get; set; }
        public Nullable<decimal> LimiteCredito { get; set; }
        public string Captacao { get; set; }
        public virtual ICollection<Comissao> Comissoes { get; set; }
        public virtual ICollection<ContatoCliente> ContatosCliente { get; set; }
        public virtual ICollection<ContaReceber> ContasReceber { get; set; }
        public virtual ICollection<Equipamento> Equipamentos { get; set; }
        public virtual ICollection<LojaCliente> LojasCliente { get; set; }
        public virtual ICollection<MovimentacaoEquipamento> MovimentacoesEquipamento { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual GrupoCliente GrupoCliente { get; set; }
        public virtual Indicacao Indicacao { get; set; }
        public virtual Lista Lista { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Regiao Regiao { get; set; }
        public virtual Situacao Situacao { get; set; }
        public virtual Transportador Transportador { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}