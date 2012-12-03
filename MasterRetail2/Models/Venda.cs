using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Venda
	{
	    public Venda()
		{
			this.ContasReceber = new List<ContaReceber>();
			this.DeclaracoesImportacao = new List<DeclaracaoImportacao>();
			this.Entradas = new List<Entrada>();
			this.ItensVenda = new List<ItemVenda>();
			this.NotasFiscais = new List<NotaFiscal>();
			this.PedidosCompra = new List<PedidoCompra>();
            this.PedidosVenda = new List<PedidoVenda>();
			this.Recebimentos = new List<RecebimentoVenda>();
            this.Volumes = new List<VolumeVenda>();
		}

        public int VendaId { get; set; }
		public string NUMERO_VDA { get; set; }
		public Nullable<int> NOTA_VDA { get; set; }
		public string TIPOOPER_VDA { get; set; }
		public Nullable<int> CondicaoPagamentoId { get; set; }
		public Nullable<int> ClienteId { get; set; }
		public Nullable<int> COD_ENTR { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<int> VendedorId { get; set; }
		public Nullable<int> ID_MVPD { get; set; }
		public Nullable<int> CFOP_NTOP { get; set; }
		public Nullable<int> OperadorId { get; set; }
		public Nullable<int> OperadorId_AUTO { get; set; }
		public Nullable<int> ID_ENPS_LOJA_VDA { get; set; }
		public Nullable<int> ID_ENPS_CLI_VDA { get; set; }
		public Nullable<int> ID_ENPS_TRAN_VDA { get; set; }
		public Nullable<int> ID_ENPS_ENT_VDA { get; set; }
		public Nullable<int> ID_ENPS_RET_VDA { get; set; }
		public Nullable<int> ID_VOL { get; set; }
		public Nullable<System.DateTime> DATA_VDA { get; set; }
		public Nullable<decimal> VLRMERC_VDA { get; set; }
		public Nullable<decimal> DESCONTO_VDA { get; set; }
		public Nullable<decimal> ACRESCIMO_VDA { get; set; }
		public Nullable<decimal> TXENTR_VDA { get; set; }
		public Nullable<decimal> SERVICO_VDA { get; set; }
		public string MODFRETE_VDA { get; set; }
		public Nullable<int> PESSOAS_VDA { get; set; }
		public Nullable<int> COMANDA_VDA { get; set; }
		public string STATUS_VDA { get; set; }
		public Nullable<decimal> FRETE_VDA { get; set; }
		public Nullable<decimal> SEGURO_VDA { get; set; }
		public Nullable<decimal> BICMS_VDA { get; set; }
		public Nullable<decimal> ICMS_VDA { get; set; }
		public Nullable<decimal> BICMSST_VDA { get; set; }
		public Nullable<decimal> ICMSST_VDA { get; set; }
		public Nullable<decimal> PIS_VDA { get; set; }
		public Nullable<decimal> COFINS_VDA { get; set; }
		public Nullable<decimal> IPI_VDA { get; set; }
		public Nullable<decimal> BISSQN_VDA { get; set; }
		public Nullable<decimal> ISSQN_VDA { get; set; }
		public Nullable<decimal> II_VDA { get; set; }
		public Nullable<decimal> VLRTOT_VDA { get; set; }
		public Nullable<decimal> BIRRF_VDA { get; set; }
		public Nullable<decimal> BPREV_VDA { get; set; }
		public Nullable<decimal> IRRF_VDA { get; set; }
		public Nullable<decimal> RCOFINS_VDA { get; set; }
		public Nullable<decimal> RCSLL_VDA { get; set; }
		public Nullable<decimal> RPIS_VDA { get; set; }
		public Nullable<decimal> RPREV_VDA { get; set; }
		public Nullable<decimal> DESP_ACESSORIA_VDA { get; set; }
		public Nullable<int> TransportadorId { get; set; }
		public Nullable<int> CFOP_NTOP_TRAN_VDA { get; set; }
		public Nullable<decimal> ICMS_TRAN_VDA { get; set; }
		public Nullable<decimal> BASECALC_TRAN_VDA { get; set; }
		public Nullable<decimal> ALIQ_TRAN_VDA { get; set; }
		public Nullable<decimal> VALOR_TRAN_VDA { get; set; }
		public Nullable<decimal> PESOLIQ_VDA { get; set; }
		public Nullable<decimal> PESOBRT_VDA { get; set; }
		public Nullable<decimal> PREV_VDA { get; set; }
		public Nullable<decimal> PISRETIDO_VDA { get; set; }
		public Nullable<decimal> COFINSRETIDO_VDA { get; set; }
		public Nullable<decimal> CSLL_VDA { get; set; }
		public Nullable<decimal> PISISSQN_VDA { get; set; }
		public Nullable<decimal> COFINSISSQN_VDA { get; set; }
		public Nullable<decimal> VLRTOTISSQN_VDA { get; set; }
		public virtual Cliente Cliente { get; set; }
		public virtual CondicaoPagamento CondicaoPagamento { get; set; }
		public virtual ICollection<ContaReceber> ContasReceber { get; set; }
        public virtual ICollection<DeclaracaoImportacao> DeclaracoesImportacao { get; set; }
        public virtual EnderecoPessoa EnderecoTransportador { get; set; }
        public virtual EnderecoPessoa EnderecoCliente { get; set; }
        public virtual EnderecoPessoa EnderecoLoja { get; set; }
        public virtual EnderecoPessoa EnderecoEntrega { get; set; }
        public virtual EnderecoPessoa EnderecoRetirada { get; set; }
		public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual Entregador Entregador { get; set; }
        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
		public virtual Loja Loja { get; set; }
        public virtual MovimentoPdv MovimentoPdv { get; set; }
		public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
		public virtual Operador Operador { get; set; }
		public virtual Operador Operador_AUTORIZADOR { get; set; }
		public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
		public virtual ICollection<PedidoVenda> PedidosVenda { get; set; }
        public virtual ICollection<RecebimentoVenda> Recebimentos{ get; set; }
		public virtual Transportador Transportador { get; set; }
        public virtual ICollection<VolumeVenda> Volumes { get; set; }
		public virtual Vendedor Vendedor { get; set; }
	}
}