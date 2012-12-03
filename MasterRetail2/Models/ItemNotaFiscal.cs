using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class ItemNotaFiscal
	{
        public ItemNotaFiscal()
		{
			this.ItensVenda = new List<ItemVenda>();
		}

        public int ItemNotaFiscalId { get; set; }
		public int ID_NF { get; set; }
		public Nullable<int> ValorPropriedadeId { get; set; }
		public Nullable<int> ID_PDLS { get; set; }
		public Nullable<int> VendedorId { get; set; }
		public Nullable<int> LocalEstoqueId { get; set; }
		public Nullable<int> CFOP_NTOP { get; set; }
		public Nullable<int> ID_ORIG { get; set; }
		public Nullable<int> UfId_OP_ITNF { get; set; }
		public Nullable<int> ID_SITB_ICMS { get; set; }
		public Nullable<int> ID_SITB_IPI { get; set; }
		public Nullable<int> ID_SITB_PIS { get; set; }
		public Nullable<int> ID_SITB_COFINS { get; set; }
		public Nullable<int> ID_MDPD { get; set; }
		public Nullable<int> ID_MDPD_ST { get; set; }
		public Nullable<int> ID_MDSP { get; set; }
		public Nullable<int> CidadeId_ISSQN_ITNF { get; set; }
		public Nullable<int> ITEM_ITNF { get; set; }
		public string TIPO_ITNF { get; set; }
		public Nullable<int> COMANDA_ITNF { get; set; }
		public Nullable<System.TimeSpan> HORA_ITNF { get; set; }
		public Nullable<decimal> QTDE_ITNF { get; set; }
		public Nullable<decimal> FATURADO_ITNF { get; set; }
		public Nullable<decimal> PRECO_ITNF { get; set; }
		public Nullable<decimal> DESCONTO_ITNF { get; set; }
		public Nullable<decimal> FRETE_ITNF { get; set; }
		public Nullable<decimal> SEGURO_ITNF { get; set; }
		public Nullable<decimal> DESP_ACESSORIA_ITNF { get; set; }
		public string CONDICIONAL_ITNF { get; set; }
		public Nullable<decimal> PROP_DESCONTO_ITNF { get; set; }
		public string PADRAO_DESCONTO_ITNF { get; set; }
		public Nullable<int> INDTOT_ITNF { get; set; }
		public Nullable<decimal> BICMS_ITNF { get; set; }
		public Nullable<decimal> PICMS_ITNF { get; set; }
		public Nullable<decimal> ICMS_ITNF { get; set; }
		public Nullable<decimal> RICMS_ITNF { get; set; }
		public Nullable<decimal> BOPICMS_ITNF { get; set; }
		public Nullable<decimal> RICMSST_ITNF { get; set; }
		public Nullable<decimal> MVA_ICMSST_ITNF { get; set; }
		public Nullable<decimal> BICMSST_ITNF { get; set; }
		public Nullable<decimal> PICMSST_ITNF { get; set; }
		public Nullable<decimal> ICMSST_ITNF { get; set; }
		public Nullable<decimal> BICMSST_UF_EMIT_ITNF { get; set; }
		public Nullable<decimal> ICMSST_UF_EMIT_ITNF { get; set; }
		public Nullable<decimal> BICMSST_UF_DEST_ITNF { get; set; }
		public Nullable<decimal> ICMSST_UF_DEST_ITNF { get; set; }
		public Nullable<decimal> BICMSST_ANT_ITNF { get; set; }
		public Nullable<decimal> ICMSST_ANT_ITNF { get; set; }
		public string SELO_IPI_ITNF { get; set; }
		public string QSELO_IPI_ITNF { get; set; }
		public string ENQ_IPI_ITNF { get; set; }
		public string CNPJ_PRODUTOR_IPI_ITNF { get; set; }
		public string CALCULO_IPI { get; set; }
		public Nullable<decimal> BIPI_ITNF { get; set; }
		public Nullable<decimal> PIPI_ITNF { get; set; }
		public Nullable<decimal> QIPI_ITNF { get; set; }
		public Nullable<decimal> VIPI_ITNF { get; set; }
		public Nullable<decimal> IPI_ITNF { get; set; }
		public string CALCULO_PIS { get; set; }
		public Nullable<decimal> BPIS_ITNF { get; set; }
		public Nullable<decimal> PPIS_ITNF { get; set; }
		public Nullable<decimal> QPIS_ITNF { get; set; }
		public Nullable<decimal> PIS_ITNF { get; set; }
		public string CALCULO_PISST { get; set; }
		public Nullable<decimal> BPISST_ITNF { get; set; }
		public Nullable<decimal> PPISST_ITNF { get; set; }
		public Nullable<decimal> QPISST_ITNF { get; set; }
		public Nullable<decimal> PISST_ITNF { get; set; }
		public string CALCULO_COFINS { get; set; }
		public Nullable<decimal> BCOFINS_ITNF { get; set; }
		public Nullable<decimal> PCOFINS_ITNF { get; set; }
		public Nullable<decimal> QCOFINS_ITNF { get; set; }
		public Nullable<decimal> COFINS_ITNF { get; set; }
		public string CALCULO_COFINSST { get; set; }
		public Nullable<decimal> BCOFINSST_ITNF { get; set; }
		public Nullable<decimal> PCOFINSST_ITNF { get; set; }
		public Nullable<decimal> QCOFINSST_ITNF { get; set; }
		public Nullable<decimal> COFINSST_ITNF { get; set; }
		public Nullable<decimal> BII_ITNF { get; set; }
		public Nullable<decimal> ADUII_ITNF { get; set; }
		public Nullable<decimal> IOFII_ITNF { get; set; }
		public Nullable<decimal> II_ITNF { get; set; }
		public string OBS_ITNF { get; set; }
		public string TISSQN_ITNF { get; set; }
		public Nullable<decimal> BISSQNST_ITNF { get; set; }
		public Nullable<decimal> PISSQNST_ITNF { get; set; }
		public Nullable<decimal> ISSQN_ITNF { get; set; }
		public Nullable<decimal> VLRMERC_ITNF { get; set; }
		public Nullable<decimal> VLRTOT_ITNF { get; set; }
		public Nullable<decimal> QTDE_FATURADA_ITNF { get; set; }
		public Nullable<decimal> QTDE_FATURAR_ITNF { get; set; }
        public virtual ICollection<ItemVenda> ItensVenda { get; set; }
		public virtual LocalEstoque LocalEstoque { get; set; }
		public virtual NotaFiscal NotaFiscal { get; set; }
		public virtual ProdutoLista ProdutoLista { get; set; }
		public virtual ValorProduto ValorProduto { get; set; }
		public virtual Vendedor Vendedor { get; set; }
	}
}

