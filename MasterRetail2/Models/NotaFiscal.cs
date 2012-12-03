using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class NotaFiscal
    {
        public NotaFiscal()
        {
            this.CuponsFiscaisNf = new List<CupomFiscalNf>();
            this.ItensNotaFiscal = new List<ItemNotaFiscal>();
        }

        public int NotaFiscalId { get; set; }
        public Nullable<int> NUMERO_NF { get; set; }
        public string CHAVE_NF { get; set; }
        public string DV_NF { get; set; }
        public string CHAVENFE_NF { get; set; }
        public Nullable<int> MODELO_NF { get; set; }
        public string TIPOOP_NF { get; set; }
        public string TIPOEMISSAO_NF { get; set; }
        public string AMBIENTE_NF { get; set; }
        public Nullable<int> FINALIDADE_NF { get; set; }
        public Nullable<int> TIPODANFE_NF { get; set; }
        public string VERSAO_NF { get; set; }
        public string VERSAOMR_NF { get; set; }
        public Nullable<int> ID_SRNF { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> FornecedorId { get; set; }
        public Nullable<int> CFOP_NTOP { get; set; }
        public Nullable<int> CFOP_NTOP_TRAN_NF { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> EntradaId { get; set; }
        public Nullable<int> VendaId { get; set; }
        public Nullable<int> CondicaoPagamentoId { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> TransportadorId { get; set; }
        public Nullable<int> VeiculoId { get; set; }
        public Nullable<int> CidadeId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.DateTime> Emissao { get; set; }
        public Nullable<System.DateTime> SAIENT_NF { get; set; }
        public string CONDICIONAL_NF { get; set; }
        public Nullable<decimal> BICMS_NF { get; set; }
        public Nullable<decimal> ICMS_NF { get; set; }
        public Nullable<decimal> BICMSST_NF { get; set; }
        public Nullable<decimal> ICMSST_NF { get; set; }
        public Nullable<decimal> IPI_NF { get; set; }
        public Nullable<decimal> IPIST_NF { get; set; }
        public Nullable<decimal> PIS_NF { get; set; }
        public Nullable<decimal> PISST_NF { get; set; }
        public Nullable<decimal> COFINS_NF { get; set; }
        public Nullable<decimal> COFINSST_NF { get; set; }
        public Nullable<decimal> VLRMERC_NF { get; set; }
        public Nullable<decimal> FRETE_NF { get; set; }
        public Nullable<decimal> SEGURO_NF { get; set; }
        public Nullable<decimal> DESCONTO_NF { get; set; }
        public Nullable<decimal> DESP_ACESSORIA_NF { get; set; }
        public Nullable<decimal> VLRTOT_NF { get; set; }
        public string MENSAGEM_NF { get; set; }
        public string OBS_NF { get; set; }
        public string STATUS_NF { get; set; }
        public Nullable<int> ID_ENPS_CLI_NF { get; set; }
        public Nullable<int> ID_ENPS_ENT_NF { get; set; }
        public Nullable<int> ID_ENPS_LOJA_NF { get; set; }
        public Nullable<int> ID_ENPS_RET_NF { get; set; }
        public Nullable<int> ID_ENPS_TRAN_NF { get; set; }
        public Nullable<decimal> II_NF { get; set; }
        public Nullable<decimal> BIRRF_NF { get; set; }
        public Nullable<decimal> IRRF_NF { get; set; }
        public Nullable<decimal> BPREV_NF { get; set; }
        public Nullable<decimal> PREV_NF { get; set; }
        public Nullable<decimal> RIPI_NF { get; set; }
        public Nullable<decimal> RPIS_NF { get; set; }
        public Nullable<decimal> RCOFINS_NF { get; set; }
        public Nullable<decimal> RCSLL_NF { get; set; }
        public string MODFRETE_NF { get; set; }
        public Nullable<decimal> BICMS_TRAN_NF { get; set; }
        public Nullable<decimal> PICMS_TRAN_NF { get; set; }
        public Nullable<decimal> ICMS_TRAN_NF { get; set; }
        public Nullable<decimal> VALOR_TRAN_NF { get; set; }
        public Nullable<decimal> PESOLIQ_NF { get; set; }
        public Nullable<decimal> PESOBRT_NF { get; set; }
        public byte[] PROC_NFE { get; set; }
        public byte[] PROCCANC_NFE { get; set; }
        public byte[] PROCINUT_NFE { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual CondicaoPagamento CondicaoPagamento { get; set; }
        public virtual ICollection<CupomFiscalNf> CuponsFiscaisNf { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA1 { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA2 { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA3 { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA4 { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<ItemNotaFiscal> ItensNotaFiscal { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual SerieNf SerieNf { get; set; }
        public virtual Transportador Transportador { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}