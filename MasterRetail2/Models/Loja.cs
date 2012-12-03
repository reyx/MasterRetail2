using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Loja
    {
        public Loja()
        {
            this.ArquivosRecebidos = new List<ArquivoRecebido>();
            this.Clientes = new List<Cliente>();
            this.CnaesLoja = new List<CnaeLoja>();
            this.ConsultoresLoja = new List<ConsultorLoja>();
            this.ContasCorrentesLojas = new List<ContaCorrenteLoja>();
            this.ContasPagar = new List<ContaPagar>();
            this.ContasReceber = new List<ContaReceber>();
            this.DespesasBase = new List<DespesaBase>();
            this.Entradas = new List<Entrada>();
            this.Equipamentos = new List<Equipamento>();
            this.EstoquesProduto = new List<EstoqueProduto>();
            this.Inventarios = new List<Inventario>();
            this.ItensMovimento = new List<ItemMovimento>();
            this.Kits = new List<Kit>();
            this.Lancamentos = new List<Lancamento>();
            this.ListasLoja = new List<ListaLoja>();
            this.MapasResumo = new List<MapaResumo>();
            this.Mensagens = new List<Mensagem>();
            this.MicroTerminais = new List<MicroTerminal>();
            this.MovimentacoesEquipamento = new List<MovimentacaoEquipamento>();
            this.Movimentos = new List<Movimento>();
            this.MovimentosPdv = new List<MovimentoPdv>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.NumerosMapaResumo = new List<NumeroMapaResumo>();
            this.Operadores = new List<Operador>();
            this.LojasOperador = new List<LojaOperador>();
            this.Pdvs = new List<Pdv>();
            this.PedidosCompra = new List<PedidoCompra>();
            this.PedidosVenda = new List<PedidoVenda>();
            this.Pessoas = new List<Pessoa>();
            this.RedesTef = new List<RedeTef>();
            this.SeriesNf = new List<SerieNf>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
            this.ValoresGrupoLoja = new List<ValorGrupoLoja>();
            this.Vendas = new List<Venda>();
            this.VendasCubo = new List<VendaCubo>();
            this.VendasProdutoCubo = new List<VendaProdutoCubo>();
            this.ProdutosLoja = new List<ProdutoLoja>();
            this.Parametros = new List<Parametro>();
        }

        public int LojaId { get; set; }
        public string Nome { get; set; }
        public string AtivoString { get; set; }
		public bool Ativo
		{
			get { return AtivoString == "A"; }
			set { AtivoString = value ? "A" : "B"; }
		}
        public Nullable<int> PessoaId { get; set; }
        public Nullable<int> RegimeTributarioId { get; set; }
        public Nullable<System.DateTime> UltimaTransacao { get; set; }
        public Nullable<int> ListaId { get; set; }
        public Nullable<int> CnaeId { get; set; }
        public Nullable<int> AmbienteNfe { get; set; }
        public Nullable<int> Danfe { get; set; }
        public virtual ICollection<ArquivoRecebido> ArquivosRecebidos { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<CnaeLoja> CnaesLoja { get; set; }
        public virtual ICollection<ConsultorLoja> ConsultoresLoja { get; set; }
        public virtual ICollection<ContaCorrenteLoja> ContasCorrentesLojas { get; set; }
        public virtual ICollection<ContaPagar> ContasPagar { get; set; }
        public virtual ICollection<ContaReceber> ContasReceber { get; set; }
        public virtual ICollection<DespesaBase> DespesasBase { get; set; }
        public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual ICollection<Equipamento> Equipamentos { get; set; }
        public virtual ICollection<EstoqueProduto> EstoquesProduto { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }
        public virtual ICollection<Kit> Kits { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual Lista Lista { get; set; }
        public virtual ICollection<ListaLoja> ListasLoja { get; set; }
        public virtual ICollection<MapaResumo> MapasResumo { get; set; }
        public virtual ICollection<Mensagem> Mensagens { get; set; }
        public virtual ICollection<MicroTerminal> MicroTerminais { get; set; }
        public virtual ICollection<MovimentacaoEquipamento> MovimentacoesEquipamento { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }
        public virtual ICollection<MovimentoPdv> MovimentosPdv { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<NumeroMapaResumo> NumerosMapaResumo { get; set; }
        public virtual ICollection<Operador> Operadores { get; set; }
        public virtual ICollection<LojaOperador> LojasOperador { get; set; }
        public virtual ICollection<Pdv> Pdvs { get; set; }
        public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
        public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<RedeTef> RedesTef { get; set; }
        public virtual ICollection<SerieNf> SeriesNf { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual ICollection<ValorGrupoLoja> ValoresGrupoLoja { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual ICollection<VendaCubo> VendasCubo { get; set; }
        public virtual ICollection<VendaProdutoCubo> VendasProdutoCubo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual ICollection<ProdutoLoja> ProdutosLoja { get; set; }
        public virtual ICollection<Parametro> Parametros { get; set; }
    }
}