using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ItemPedidoCompra
	{
        public int ItemPedidoCompraId { get; set; }
		public int ID_PDCP { get; set; }
		public Nullable<int> ValorPropriedadeId { get; set; }
		public Nullable<int> ID_PDLS { get; set; }
		public Nullable<int> VendedorId { get; set; }
		public Nullable<int> LocalEstoqueId { get; set; }
		public Nullable<int> CFOP_NTOP { get; set; }
		public Nullable<int> ID_ORIG { get; set; }
		public Nullable<int> UfId_OP_ITPC { get; set; }
		public Nullable<int> ID_SITB_ICMS { get; set; }
		public Nullable<int> ID_SITB_IPI { get; set; }
		public Nullable<int> ID_SITB_PIS { get; set; }
		public Nullable<int> ID_SITB_COFINS { get; set; }
		public Nullable<int> ID_MDPD { get; set; }
		public Nullable<int> ID_MDPD_ST { get; set; }
		public Nullable<int> ID_MDSP { get; set; }
		public Nullable<int> CidadeId_ISSQN_ITPC { get; set; }
		public Nullable<int> ITEM_ITPC { get; set; }
		public string TIPO_ITPC { get; set; }
		public Nullable<int> COMANDA_ITPC { get; set; }
		public Nullable<System.TimeSpan> HORA_ITPC { get; set; }
		public Nullable<decimal> QTDE_ITPC { get; set; }
		public Nullable<decimal> FATURADO_ITPC { get; set; }
		public Nullable<decimal> PRECO_ITPC { get; set; }
		public Nullable<decimal> DESCONTO_ITPC { get; set; }
		public Nullable<decimal> FRETE_ITPC { get; set; }
		public Nullable<decimal> SEGURO_ITPC { get; set; }
		public Nullable<decimal> DESP_ACESSORIA_ITPC { get; set; }
		public string CONDICIONAL_ITPC { get; set; }
		public Nullable<decimal> PROP_DESCONTO_ITPC { get; set; }
		public string PADRAO_DESCONTO_ITPC { get; set; }
		public Nullable<int> INDTOT_ITPC { get; set; }
		public Nullable<decimal> BICMS_ITPC { get; set; }
		public Nullable<decimal> PICMS_ITPC { get; set; }
		public Nullable<decimal> ICMS_ITPC { get; set; }
		public Nullable<decimal> RICMS_ITPC { get; set; }
		public Nullable<decimal> BOPICMS_ITPC { get; set; }
		public Nullable<decimal> RICMSST_ITPC { get; set; }
		public Nullable<decimal> MVA_ICMSST_ITPC { get; set; }
		public Nullable<decimal> BICMSST_ITPC { get; set; }
		public Nullable<decimal> PICMSST_ITPC { get; set; }
		public Nullable<decimal> ICMSST_ITPC { get; set; }
		public Nullable<decimal> BICMSST_UF_EMIT_ITPC { get; set; }
		public Nullable<decimal> ICMSST_UF_EMIT_ITPC { get; set; }
		public Nullable<decimal> BICMSST_UF_DEST_ITPC { get; set; }
		public Nullable<decimal> ICMSST_UF_DEST_ITPC { get; set; }
		public Nullable<decimal> BICMSST_ANT_ITPC { get; set; }
		public Nullable<decimal> ICMSST_ANT_ITPC { get; set; }
		public string SELO_IPI_ITPC { get; set; }
		public string QSELO_IPI_ITPC { get; set; }
		public string ENQ_IPI_ITPC { get; set; }
		public string CNPJ_PRODUTOR_IPI_ITPC { get; set; }
		public string CALCULO_IPI { get; set; }
		public Nullable<decimal> BIPI_ITPC { get; set; }
		public Nullable<decimal> PIPI_ITPC { get; set; }
		public Nullable<decimal> QIPI_ITPC { get; set; }
		public Nullable<decimal> VIPI_ITPC { get; set; }
		public Nullable<decimal> IPI_ITPC { get; set; }
		public string CALCULO_PIS { get; set; }
		public Nullable<decimal> BPIS_ITPC { get; set; }
		public Nullable<decimal> PPIS_ITPC { get; set; }
		public Nullable<decimal> QPIS_ITPC { get; set; }
		public Nullable<decimal> PIS_ITPC { get; set; }
		public string CALCULO_PISST { get; set; }
		public Nullable<decimal> BPISST_ITPC { get; set; }
		public Nullable<decimal> PPISST_ITPC { get; set; }
		public Nullable<decimal> QPISST_ITPC { get; set; }
		public Nullable<decimal> PISST_ITPC { get; set; }
		public string CALCULO_COFINS { get; set; }
		public Nullable<decimal> BCOFINS_ITPC { get; set; }
		public Nullable<decimal> PCOFINS_ITPC { get; set; }
		public Nullable<decimal> QCOFINS_ITPC { get; set; }
		public Nullable<decimal> COFINS_ITPC { get; set; }
		public string CALCULO_COFINSST { get; set; }
		public Nullable<decimal> BCOFINSST_ITPC { get; set; }
		public Nullable<decimal> PCOFINSST_ITPC { get; set; }
		public Nullable<decimal> QCOFINSST_ITPC { get; set; }
		public Nullable<decimal> COFINSST_ITPC { get; set; }
		public Nullable<decimal> BII_ITPC { get; set; }
		public Nullable<decimal> ADUII_ITPC { get; set; }
		public Nullable<decimal> IOFII_ITPC { get; set; }
		public Nullable<decimal> II_ITPC { get; set; }
		public string OBS_ITPC { get; set; }
		public string TISSQN_ITPC { get; set; }
		public Nullable<decimal> BISSQNST_ITPC { get; set; }
		public Nullable<decimal> PISSQNST_ITPC { get; set; }
		public Nullable<decimal> ISSQN_ITPC { get; set; }
		public Nullable<decimal> VLRMERC_ITPC { get; set; }
		public Nullable<decimal> VLRTOT_ITPC { get; set; }
		public Nullable<decimal> QTDE_FATURADA_ITPC { get; set; }
		public Nullable<decimal> QTDE_FATURAR_ITPC { get; set; }
		public virtual LocalEstoque LocalEstoque { get; set; }
		public virtual PedidoCompra PedidoCompra { get; set; }
		public virtual ProdutoLista ProdutoLista { get; set; }
		public virtual ValorProduto ValorProduto { get; set; }
		public virtual Vendedor Vendedor { get; set; }
	}
}

