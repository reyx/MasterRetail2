using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ItemVenda
    {
        public ItemVenda()
        {
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int ItemVendaId { get; set; }
        public int ID_VLPR { get; set; }
        public Nullable<int> VendaId { get; set; }
        public Nullable<int> ID_ITNF { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> ID_PDLS { get; set; }
        public Nullable<int> CFOP_NTOP { get; set; }
        public Nullable<int> ITEM_ITVD { get; set; }
        public Nullable<decimal> QTDE_ITVD { get; set; }
        public Nullable<decimal> PRECO_ITVD { get; set; }
        public string ENTREGUE_ITVD { get; set; }
        public Nullable<decimal> QTDEENT_ITVD { get; set; }
        public Nullable<int> COMANDA_ITVD { get; set; }
        public Nullable<System.TimeSpan> HORA_ITVD { get; set; }
        public Nullable<decimal> DESCONTO_ITVD { get; set; }
        public Nullable<decimal> SEGURO_ITVD { get; set; }
        public Nullable<decimal> FRETE_ITVD { get; set; }
        public Nullable<decimal> DESP_ACESSORIA_ITVD { get; set; }
        public Nullable<decimal> ICMS_ITVD { get; set; }
        public Nullable<decimal> BICMS_ITVD { get; set; }
        public string OICMS_ITVD { get; set; }
        public string MICMS_ITVD { get; set; }
        public Nullable<decimal> PICMS_ITVD { get; set; }
        public Nullable<decimal> QICMS_ITVD { get; set; }
        public string SICMS_ITVD { get; set; }
        public string TICMS_ITVD { get; set; }
        public Nullable<decimal> VICMS_ITVD { get; set; }
        public Nullable<decimal> BICMSST_ITVD { get; set; }
        public Nullable<decimal> ICMSST_ITVD { get; set; }
        public Nullable<decimal> PICMSST_ITVD { get; set; }
        public Nullable<decimal> QICMSST_ITVD { get; set; }
        public string TICMSST_ITVD { get; set; }
        public Nullable<decimal> VICMSST_ITVD { get; set; }
        public Nullable<decimal> PIS_ITVD { get; set; }
        public Nullable<decimal> BPIS_ITVD { get; set; }
        public Nullable<decimal> PPIS_ITVD { get; set; }
        public Nullable<decimal> QPIS_ITVD { get; set; }
        public string TPIS_ITVD { get; set; }
        public Nullable<decimal> VPIS_ITVD { get; set; }
        public Nullable<decimal> PISST_ITVD { get; set; }
        public Nullable<decimal> BPISST_ITVD { get; set; }
        public Nullable<decimal> PPISST_ITVD { get; set; }
        public Nullable<decimal> QPISST_ITVD { get; set; }
        public Nullable<decimal> VPISST_ITVD { get; set; }
        public string TPISST_ITVD { get; set; }
        public Nullable<decimal> COFINS_ITVD { get; set; }
        public Nullable<decimal> PCOFINS_ITVD { get; set; }
        public Nullable<decimal> QCOFINS_ITVD { get; set; }
        public Nullable<decimal> VCOFINS_ITVD { get; set; }
        public Nullable<decimal> BCOFINS_ITVD { get; set; }
        public string TCOFINS_ITVD { get; set; }
        public Nullable<decimal> COFINSST_ITVD { get; set; }
        public Nullable<decimal> PCOFINSST_ITVD { get; set; }
        public Nullable<decimal> QCOFINSST_ITVD { get; set; }
        public Nullable<decimal> VCOFINSST_ITVD { get; set; }
        public Nullable<decimal> BCOFINSST_ITVD { get; set; }
        public string TCOFINSST_ITVD { get; set; }
        public Nullable<decimal> IPI_ITVD { get; set; }
        public Nullable<decimal> PIPI_ITVD { get; set; }
        public Nullable<decimal> QIPI_ITVD { get; set; }
        public Nullable<decimal> VIPI_ITVD { get; set; }
        public Nullable<decimal> BIPI_ITVD { get; set; }
        public string TIPI_ITVD { get; set; }
        public Nullable<decimal> IPIST_ITVD { get; set; }
        public Nullable<decimal> PIPIST_ITVD { get; set; }
        public Nullable<decimal> QIPIST_ITVD { get; set; }
        public Nullable<decimal> VIPIST_ITVD { get; set; }
        public Nullable<decimal> BIPIST_ITVD { get; set; }
        public string TIPIST_ITVD { get; set; }
        public Nullable<decimal> ISSQN_ITVD { get; set; }
        public Nullable<decimal> PISSQN_ITVD { get; set; }
        public Nullable<decimal> QISSQN_ITVD { get; set; }
        public Nullable<decimal> VISSQN_ITVD { get; set; }
        public Nullable<decimal> BISSQN_ITVD { get; set; }
        public string TISSQN_ITVD { get; set; }
        public Nullable<decimal> ISSQNST_ITVD { get; set; }
        public Nullable<decimal> PISSQNST_ITVD { get; set; }
        public Nullable<decimal> QISSQNST_ITVD { get; set; }
        public Nullable<decimal> VISSQNST_ITVD { get; set; }
        public Nullable<decimal> BISSQNST_ITVD { get; set; }
        public string TISSQNST_ITVD { get; set; }
        public Nullable<decimal> RICMS_ITVD { get; set; }
        public Nullable<decimal> ROPICMS_ITVD { get; set; }
        public string MOTDESICMS_ITVD { get; set; }
        public Nullable<decimal> PCREDICMS_ITVD { get; set; }
        public Nullable<decimal> CREDITOICMS_ITVD { get; set; }
        public Nullable<decimal> BICMSRETIDO_ITVD { get; set; }
        public Nullable<decimal> ICMSRETIDO_ITVD { get; set; }
        public string MICMSST_ITVD { get; set; }
        public Nullable<decimal> RICMSST_ITVD { get; set; }
        public Nullable<decimal> MVAICMSST_ITVD { get; set; }
        public Nullable<int> ICMSST_ID_UF_ITVD { get; set; }
        public Nullable<decimal> BICMSST_UF_REM_ITVD { get; set; }
        public Nullable<decimal> ICMSST_UF_REM_ITVD { get; set; }
        public Nullable<decimal> BICMSST_UF_DEST_ITVD { get; set; }
        public Nullable<decimal> ICMSST_UF_DEST_ITVD { get; set; }
        public Nullable<decimal> BICMSST_RETIDO_ITVD { get; set; }
        public Nullable<decimal> ICMSST_RETIDO_ITVD { get; set; }
        public Nullable<decimal> OPICMS_ITVD { get; set; }
        public string SCOFINS_ITVD { get; set; }
        public string SPIS_ITVD { get; set; }
        public Nullable<decimal> IPIPESO_ITVD { get; set; }
        public string SIPI_ITVD { get; set; }
        public string SELOIPI_ITVD { get; set; }
        public Nullable<int> QSELOIPI_ITVD { get; set; }
        public string ENQIPI_ITVD { get; set; }
        public string CENQIPI_ITVD { get; set; }
        public string CNPJIPI_ITVD { get; set; }
        public Nullable<decimal> BII_ITVD { get; set; }
        public Nullable<decimal> DESPADUII_ITVD { get; set; }
        public Nullable<decimal> IOFII_ITVD { get; set; }
        public Nullable<decimal> II_ITVD { get; set; }
        public Nullable<int> CidadeId_ISSQN_ITVD { get; set; }
        public Nullable<decimal> VLRMERC_ITVD { get; set; }
        public Nullable<decimal> VLRTOT_ITVD { get; set; }
        public Nullable<int> INDTOT_ITVD { get; set; }
        public string INFOADI_ITVD { get; set; }
        public virtual ItemNotaFiscal ItemNotaFiscal { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual ProdutoLista ProdutoLista { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}