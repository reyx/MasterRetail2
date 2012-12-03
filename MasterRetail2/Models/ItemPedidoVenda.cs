using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ItemPedidoVenda
	{
        public int ItemPedidoVendaId { get; set; }
		public int ID_PDVD { get; set; }
		public Nullable<int> ValorPropriedadeId { get; set; }
		public Nullable<int> ID_PDLS { get; set; }
		public Nullable<int> VendedorId { get; set; }
		public Nullable<int> LocalEstoqueId { get; set; }
        public string DESC_NTOP_ITPV { get; set; }
		public Nullable<int> ID_ORIG { get; set; }
		public Nullable<int> UfId_OP_ITPV { get; set; }
		public Nullable<int> ID_SITB_ICMS { get; set; }
		public Nullable<int> ID_SITB_IPI { get; set; }
		public Nullable<int> ID_SITB_PIS { get; set; }
		public Nullable<int> ID_SITB_COFINS { get; set; }
		public Nullable<int> ID_MDPD { get; set; }
		public Nullable<int> ID_MDPD_ST { get; set; }
		public Nullable<int> ID_MDSP { get; set; }
		public Nullable<int> CidadeId_ISSQN_ITPV { get; set; }
		public Nullable<int> ITEM_ITPV { get; set; }
		public string TIPO_ITPV { get; set; }
		public Nullable<int> COMANDA_ITPV { get; set; }
		public Nullable<System.TimeSpan> HORA_ITPV { get; set; }
		public Nullable<decimal> QTDE_ITPV { get; set; }
		public Nullable<decimal> FATURADO_ITPV { get; set; }
		public Nullable<decimal> PRECO_ITPV { get; set; }
		public Nullable<decimal> DESCONTO_ITPV { get; set; }
		public Nullable<decimal> FRETE_ITPV { get; set; }
		public Nullable<decimal> SEGURO_ITPV { get; set; }
		public Nullable<decimal> DESP_ACESSORIA_ITPV { get; set; }
		public string CONDICIONAL_ITPV { get; set; }
		public Nullable<decimal> PROP_DESCONTO_ITPV { get; set; }
		public string PADRAO_DESCONTO_ITPV { get; set; }
		public Nullable<int> INDTOT_ITPV { get; set; }
		public Nullable<decimal> BICMS_ITPV { get; set; }
		public Nullable<decimal> PICMS_ITPV { get; set; }
		public Nullable<decimal> ICMS_ITPV { get; set; }
		public Nullable<decimal> RICMS_ITPV { get; set; }
		public Nullable<decimal> BOPICMS_ITPV { get; set; }
		public Nullable<decimal> RICMSST_ITPV { get; set; }
		public Nullable<decimal> MVA_ICMSST_ITPV { get; set; }
		public Nullable<decimal> BICMSST_ITPV { get; set; }
		public Nullable<decimal> PICMSST_ITPV { get; set; }
		public Nullable<decimal> ICMSST_ITPV { get; set; }
		public Nullable<decimal> BICMSST_UF_EMIT_ITPV { get; set; }
		public Nullable<decimal> ICMSST_UF_EMIT_ITPV { get; set; }
		public Nullable<decimal> BICMSST_UF_DEST_ITPV { get; set; }
		public Nullable<decimal> ICMSST_UF_DEST_ITPV { get; set; }
		public Nullable<decimal> BICMSST_ANT_ITPV { get; set; }
		public Nullable<decimal> ICMSST_ANT_ITPV { get; set; }
        public Nullable<decimal> PCREDICMS_ITPV { get; set; }
        public Nullable<decimal> CREDICMS_ITPV { get; set; }
		public string SELO_IPI_ITPV { get; set; }
		public string QSELO_IPI_ITPV { get; set; }
		public string ENQ_IPI_ITPV { get; set; }
		public string CNPJ_PRODUTOR_IPI_ITPV { get; set; }
		public string CALCULO_IPI { get; set; }
		public Nullable<decimal> BIPI_ITPV { get; set; }
		public Nullable<decimal> PIPI_ITPV { get; set; }
		public Nullable<decimal> QIPI_ITPV { get; set; }
		public Nullable<decimal> VIPI_ITPV { get; set; }
		public Nullable<decimal> IPI_ITPV { get; set; }
		public string CALCULO_PIS { get; set; }
		public Nullable<decimal> BPIS_ITPV { get; set; }
		public Nullable<decimal> PPIS_ITPV { get; set; }
		public Nullable<decimal> QPIS_ITPV { get; set; }
        public Nullable<decimal> VPIS_ITPV { get; set; }
		public Nullable<decimal> PIS_ITPV { get; set; }
		public string CALCULO_PISST { get; set; }
		public Nullable<decimal> BPISST_ITPV { get; set; }
		public Nullable<decimal> PPISST_ITPV { get; set; }
		public Nullable<decimal> QPISST_ITPV { get; set; }
        public Nullable<decimal> VPISST_ITPV { get; set; }
		public Nullable<decimal> PISST_ITPV { get; set; }
		public string CALCULO_COFINS { get; set; }
		public Nullable<decimal> BCOFINS_ITPV { get; set; }
		public Nullable<decimal> PCOFINS_ITPV { get; set; }
		public Nullable<decimal> QCOFINS_ITPV { get; set; }
        public Nullable<decimal> VCOFINS_ITPV { get; set; }
		public Nullable<decimal> COFINS_ITPV { get; set; }
		public string CALCULO_COFINSST { get; set; }
		public Nullable<decimal> BCOFINSST_ITPV { get; set; }
		public Nullable<decimal> PCOFINSST_ITPV { get; set; }
		public Nullable<decimal> QCOFINSST_ITPV { get; set; }
        public Nullable<decimal> VCOFINSST_ITPV { get; set; }
		public Nullable<decimal> COFINSST_ITPV { get; set; }
		public Nullable<decimal> BII_ITPV { get; set; }
		public Nullable<decimal> ADUII_ITPV { get; set; }
		public Nullable<decimal> IOFII_ITPV { get; set; }
		public Nullable<decimal> II_ITPV { get; set; }
		public string OBS_ITPV { get; set; }
        public string INFO_FISCO_ITPV { get; set; }
		public string TISSQN_ITPV { get; set; }
		public Nullable<decimal> BISSQNST_ITPV { get; set; }
		public Nullable<decimal> PISSQNST_ITPV { get; set; }
		public Nullable<decimal> ISSQN_ITPV { get; set; }
		public Nullable<decimal> VLRMERC_ITPV { get; set; }
		public Nullable<decimal> VLRTOT_ITPV { get; set; }
		public Nullable<decimal> QTDE_FATURADA_ITPV { get; set; }
		public Nullable<decimal> QTDE_FATURAR_ITPV { get; set; }
		public virtual LocalEstoque LocalEstoque { get; set; }
		public virtual PedidoVenda PedidoVenda { get; set; }
		public virtual ProdutoLista ProdutoLista { get; set; }
		public virtual ValorProduto ValorProduto { get; set; }
		public virtual Vendedor Vendedor { get; set; }
	}
}

