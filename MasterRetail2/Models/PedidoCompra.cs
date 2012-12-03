using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class PedidoCompra
    {
        public PedidoCompra()
        {
            this.ITEM_PEDIDO_COMPRA = new List<ItemPedidoCompra>();
        }

        public int PedidoCompraId { get; set; }
        public Nullable<int> NUMERO_PDCP { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> FornecedorId { get; set; }
        public Nullable<int> CFOP_NTOP { get; set; }
        public Nullable<int> CFOP_NTOP_TRAN_PDCP { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> EntradaId { get; set; }
        public Nullable<int> CondicaoPagamentoId { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> TransportadorId { get; set; }
        public Nullable<int> VeiculoId { get; set; }
        public Nullable<System.DateTime> DATA_PDCP { get; set; }
        public Nullable<System.DateTime> EMISSAO_PDCP { get; set; }
        public string CONDICIONAL_PDCP { get; set; }
        public Nullable<decimal> BICMS_PDCP { get; set; }
        public Nullable<decimal> ICMS_PDCP { get; set; }
        public Nullable<decimal> BICMSST_PDCP { get; set; }
        public Nullable<decimal> ICMSST_PDCP { get; set; }
        public Nullable<decimal> IPI_PDCP { get; set; }
        public Nullable<decimal> IPIST_PDCP { get; set; }
        public Nullable<decimal> PIS_PDCP { get; set; }
        public Nullable<decimal> PISST_PDCP { get; set; }
        public Nullable<decimal> COFINS_PDCP { get; set; }
        public Nullable<decimal> COFINSST_PDCP { get; set; }
        public Nullable<decimal> VLRMERC_PDCP { get; set; }
        public Nullable<decimal> FRETE_PDCP { get; set; }
        public Nullable<decimal> SEGURO_PDCP { get; set; }
        public Nullable<decimal> DESCONTO_PDCP { get; set; }
        public Nullable<decimal> DESP_ACESSORIA_PDCP { get; set; }
        public Nullable<decimal> VLRTOT_PDCP { get; set; }
        public string OBS_PDCP { get; set; }
        public string TIPO_PDCP { get; set; }
        public string STATUS_PDCP { get; set; }
        public Nullable<int> ID_ENPS_FORN_PDCP { get; set; }
        public Nullable<int> ID_ENPS_ENT_PDCP { get; set; }
        public Nullable<int> ID_ENPS_LOJA_PDCP { get; set; }
        public Nullable<int> ID_ENPS_RET_PDCP { get; set; }
        public Nullable<int> ID_ENPS_TRAN_PDCP { get; set; }
        public Nullable<decimal> II_PDCP { get; set; }
        public Nullable<decimal> BIRRF_PDCP { get; set; }
        public Nullable<decimal> IRRF_PDCP { get; set; }
        public Nullable<decimal> BPREV_PDCP { get; set; }
        public Nullable<decimal> PREV_PDCP { get; set; }
        public Nullable<decimal> RIPI_PDCP { get; set; }
        public Nullable<decimal> RPIS_PDCP { get; set; }
        public Nullable<decimal> RCOFINS_PDCP { get; set; }
        public Nullable<decimal> RCSLL_PDCP { get; set; }
        public string MODFRETE_PDCP { get; set; }
        public Nullable<decimal> BICMS_TRAN_PDCP { get; set; }
        public Nullable<decimal> PICMS_TRAN_PDCP { get; set; }
        public Nullable<decimal> ICMS_TRAN_PDCP { get; set; }
        public Nullable<decimal> VALOR_TRAN_PDCP { get; set; }
        public Nullable<decimal> PESOLIQ_PDCP { get; set; }
        public Nullable<decimal> PESOBRT_PDCP { get; set; }
        public virtual CondicaoPagamento CondicaoPagamento { get; set; }
        public virtual EnderecoPessoa EnderecoPessoa { get; set; }
        public virtual EnderecoPessoa EnderecoPessoa1 { get; set; }
        public virtual EnderecoPessoa EnderecoPessoa2 { get; set; }
        public virtual EnderecoPessoa EnderecoPessoa3 { get; set; }
        public virtual EnderecoPessoa EnderecoPessoa4 { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<ItemPedidoCompra> ITEM_PEDIDO_COMPRA { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual Transportador Transportador { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}