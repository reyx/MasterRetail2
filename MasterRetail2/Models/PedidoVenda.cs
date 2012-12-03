using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class PedidoVenda
    {
        public PedidoVenda()
        {
            this.ITENS_PEDIDO_VENDA = new List<ItemPedidoVenda>();
        }

        public int PedidoVendaId { get; set; }
        public Nullable<int> NUMERO_PDVD { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public string DESC_NTOP_PDVD { get; set; }
        public string DESC_NTOP_TRAN_PDVD { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> VendaId { get; set; }
        public Nullable<int> CondicaoPagamentoId { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> TransportadorId { get; set; }
        public Nullable<int> VeiculoId { get; set; }
        public Nullable<System.DateTime> DATA_PDVD { get; set; }
        public Nullable<System.DateTime> EMISSAO_PDVD { get; set; }
        public string CONDICIONAL_PDVD { get; set; }
        public Nullable<decimal> BICMS_PDVD { get; set; }
        public Nullable<decimal> ICMS_PDVD { get; set; }
        public Nullable<decimal> BICMSST_PDVD { get; set; }
        public Nullable<decimal> ICMSST_PDVD { get; set; }
        public Nullable<decimal> IPI_PDVD { get; set; }
        public Nullable<decimal> IPIST_PDVD { get; set; }
        public Nullable<decimal> PIS_PDVD { get; set; }
        public Nullable<decimal> PISST_PDVD { get; set; }
        public Nullable<decimal> COFINS_PDVD { get; set; }
        public Nullable<decimal> COFINSST_PDVD { get; set; }
        public Nullable<decimal> VLRMERC_PDVD { get; set; }
        public Nullable<decimal> FRETE_PDVD { get; set; }
        public Nullable<decimal> SEGURO_PDVD { get; set; }
        public Nullable<decimal> DESCONTO_PDVD { get; set; }
        public Nullable<decimal> DESP_ACESSORIA_PDVD { get; set; }
        public Nullable<decimal> VLRTOT_PDVD { get; set; }
        public string OBS_PDVD { get; set; }
        public string TIPO_PDVD { get; set; }
        public string STATUS_PDVD { get; set; }
        public Nullable<int> ID_ENPS_CLI_PDVD { get; set; }
        public Nullable<int> ID_ENPS_ENT_PDVD { get; set; }
        public Nullable<int> ID_ENPS_LOJA_PDVD { get; set; }
        public Nullable<int> ID_ENPS_RET_PDVD { get; set; }
        public Nullable<int> ID_ENPS_TRAN_PDVD { get; set; }
        public Nullable<decimal> II_PDVD { get; set; }
        public Nullable<decimal> BIRRF_PDVD { get; set; }
        public Nullable<decimal> IRRF_PDVD { get; set; }
        public Nullable<decimal> BPREV_PDVD { get; set; }
        public Nullable<decimal> PREV_PDVD { get; set; }
        public Nullable<decimal> RIPI_PDVD { get; set; }
        public Nullable<decimal> RPIS_PDVD { get; set; }
        public Nullable<decimal> RCOFINS_PDVD { get; set; }
        public Nullable<decimal> RCSLL_PDVD { get; set; }
        public string MODFRETE_PDVD { get; set; }
        public Nullable<decimal> BICMS_TRAN_PDVD { get; set; }
        public Nullable<decimal> PICMS_TRAN_PDVD { get; set; }
        public Nullable<decimal> ICMS_TRAN_PDVD { get; set; }
        public Nullable<decimal> VALOR_TRAN_PDVD { get; set; }
        public Nullable<decimal> PESOLIQ_PDVD { get; set; }
        public Nullable<decimal> PESOBRT_PDVD { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual CondicaoPagamento CondicaoPagamento { get; set; }
        public virtual EnderecoPessoa EnderecoCliente { get; set; }
        public virtual EnderecoPessoa EnderecoEntrega { get; set; }
        public virtual EnderecoPessoa EnderecoLoja { get; set; }
        public virtual EnderecoPessoa EnderecoRetirada { get; set; }
        public virtual EnderecoPessoa EnderecoTransportador { get; set; }
        public virtual ICollection<ItemPedidoVenda> ITENS_PEDIDO_VENDA { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual Transportador Transportador { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}