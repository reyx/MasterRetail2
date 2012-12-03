using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Operador
    {
        public Operador()
        {
            this.Entradas = new List<Entrada>();
            this.FuncoesOperador = new List<FuncaoOperador>();
            this.Inventarios = new List<Inventario>();
            this.ItensInventario = new List<ItemInventario>();
            this.ItensMovimento = new List<ItemMovimento>();
            this.Lancamentos = new List<Lancamento>();
            this.Links = new List<Link>();
            this.LogsAcesso = new List<LogAcesso>();
            this.LojasOperador = new List<LojaOperador>();
            this.MovimentacoesEquipamento = new List<MovimentacaoEquipamento>();
            this.Movimentos = new List<Movimento>();
            this.MovimentosPdv = new List<MovimentoPdv>();
            this.MovimentosPdvAbertura = new List<MovimentoPdv>();
            this.MovimentosPdvFechamento = new List<MovimentoPdv>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.OcorrenciasPdv = new List<OcorrenciaPdv>();
            this.Vendas = new List<Venda>();
            this.PedidosCompra = new List<PedidoCompra>();
            this.PedidosVenda = new List<PedidoVenda>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
            this.Vendas1 = new List<Venda>();
            this.ValoresGrupo = new List<OperadorValorGrupo>();
        }

        public int OperadorId { get; set; }
        public string Codigo { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> CodigoLoja { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<int> PessoaId { get; set; }
        public string NivelPdv { get; set; }
        public string NivelRetaguarda { get; set; }
        public string NivelLoja { get; set; }
        public Nullable<decimal> PercentualDesconto { get; set; }
        public Nullable<decimal> ValorDesconto { get; set; }
        public string SituacaoCartao { get; set; }
        public string Trilha { get; set; }
        public Nullable<int> PerfilId { get; set; }
        public string Tema { get; set; }
        public string AtivoString { get; set; }
        public bool Ativo
        {
            get { return AtivoString == "A"; }
            set { AtivoString = value ? "A" : "B"; }
        }
        public string MensagemInativo { get; set; }
        public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual ICollection<FuncaoOperador> FuncoesOperador { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<ItemInventario> ItensInventario { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual ICollection<LogAcesso> LogsAcesso { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ICollection<LojaOperador> LojasOperador { get; set; }
        public virtual ICollection<MovimentacaoEquipamento> MovimentacoesEquipamento { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<MovimentoPdv> MovimentosPdv { get; set; }
        public virtual ICollection<MovimentoPdv> MovimentosPdvAbertura { get; set; }
        public virtual ICollection<MovimentoPdv> MovimentosPdvFechamento { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<OcorrenciaPdv> OcorrenciasPdv { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
        public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual ICollection<Venda> Vendas1 { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<OperadorValorGrupo> ValoresGrupo { get; set; }
    }
}