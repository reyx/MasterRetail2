using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemEntrada
    {
        public ItemEntrada()
        {
            this.PedidosTransito = new List<PedidoTransito>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int ItemEntradaId { get; set; }
        public int EntradaId { get; set; }
        public Nullable<int> ValorPropriedadeId { get; set; }
        public Nullable<int> ProdutoListaId { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> LocalEstoqueId { get; set; }
        public Nullable<int> CFOP_NTOP { get; set; }
        public Nullable<int> OrigemId { get; set; }
        public Nullable<int> UfOperacaoPropriaId { get; set; }
        public Nullable<int> SituacaoTributariaIcmsId { get; set; }
        public Nullable<int> SituacaoTributariaIpiId { get; set; }
        public Nullable<int> SituacaoTributariaPisId { get; set; }
        public Nullable<int> SituacaoTributariaCofinsId { get; set; }
        public Nullable<int> ID_MDPD { get; set; }
        public Nullable<int> ID_MDPD_ST { get; set; }
        public Nullable<int> ID_MDSP { get; set; }
        public Nullable<int> CidadeIssqId { get; set; }
        public Nullable<int> Item { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> Comanda { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<decimal> Faturado { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public Nullable<decimal> Frete { get; set; }
        public Nullable<decimal> Seguro { get; set; }
        public Nullable<decimal> DespesaAcessoria { get; set; }
        public string Condicional { get; set; }
        public Nullable<decimal> ProporcaoDesconto { get; set; }
        public string PadraoDesconto { get; set; }
        public Nullable<int> INDTOT_ITEN { get; set; }
        public Nullable<decimal> BaseIcms { get; set; }
        public Nullable<decimal> AliquotaIcms { get; set; }
        public Nullable<decimal> Icms { get; set; }
        public Nullable<decimal> IcmsRetido { get; set; }
        public Nullable<decimal> BaseIcmsOperacaoPropria { get; set; }
        public Nullable<decimal> IcmsStRetido { get; set; }
        public Nullable<decimal> MvaIcmsSt { get; set; }
        public Nullable<decimal> BaseIcmsSt { get; set; }
        public Nullable<decimal> AliquotaIcmsSt { get; set; }
        public Nullable<decimal> IcmsSt { get; set; }
        public Nullable<decimal> BaseIcmsStUfEmitente { get; set; }
        public Nullable<decimal> IcmsStUfEmitente { get; set; }
        public Nullable<decimal> BaseIcmsStUfDestinatario { get; set; }
        public Nullable<decimal> IcmsStUfDestinatario { get; set; }
        public Nullable<decimal> BaseIcmsStRetidoAnteriormente { get; set; }
        public Nullable<decimal> IcmsStRetidoAnteriormente { get; set; }
        public string SeloIpi { get; set; }
        public string QuantidadeSeloIpi { get; set; }
        public string EnquadramentoIpi { get; set; }
        public string CnpjProdutor { get; set; }
        public string TipoCalculoIpi { get; set; }
        public Nullable<decimal> BaseIpi { get; set; }
        public Nullable<decimal> AliquotaIpi { get; set; }
        public Nullable<decimal> QuantidadeIpi { get; set; }
        public Nullable<decimal> ValorIpi { get; set; }
        public Nullable<decimal> Ipi { get; set; }
        public string TipoCalculoPis { get; set; }
        public Nullable<decimal> BasePis { get; set; }
        public Nullable<decimal> AliquotaPis { get; set; }
        public Nullable<decimal> QuantidadePis { get; set; }
        public Nullable<decimal> Pis { get; set; }
        public string TipoCalculoPisSt { get; set; }
        public Nullable<decimal> BasePisSt { get; set; }
        public Nullable<decimal> AliquotaPisSt { get; set; }
        public Nullable<decimal> QuantidadePisSt { get; set; }
        public Nullable<decimal> PisSt { get; set; }
        public string TipoCalculoCofins { get; set; }
        public Nullable<decimal> BaseCofins { get; set; }
        public Nullable<decimal> AliquotaCofins { get; set; }
        public Nullable<decimal> QuantidadeCofins { get; set; }
        public Nullable<decimal> Cofins { get; set; }
        public string TipoCalculoCofinsSt { get; set; }
        public Nullable<decimal> BaseCofinsSt { get; set; }
        public Nullable<decimal> AliquotaCofinsSt { get; set; }
        public Nullable<decimal> QuantidadeCofinsSt { get; set; }
        public Nullable<decimal> CofinsSt { get; set; }
        public Nullable<decimal> BaseImpostoImportacao { get; set; }
        public Nullable<decimal> AduaneiroImpostoImportacao { get; set; }
        public Nullable<decimal> IofImpostoImportacao { get; set; }
        public Nullable<decimal> ImpostoImportacao { get; set; }
        public string Observacao { get; set; }
        public string TipoIssqn { get; set; }
        public Nullable<decimal> BaseIssqn { get; set; }
        public Nullable<decimal> AliquotaIssqn { get; set; }
        public Nullable<decimal> Issqn { get; set; }
        public Nullable<decimal> ValorMercadoria { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public Nullable<decimal> QuantidadeFaturada { get; set; }
        public Nullable<decimal> QuantidadeFaturar { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual ICollection<PedidoTransito> PedidosTransito { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual LocalEstoque LocalEstoque { get; set; }
        public virtual ProdutoLista ProdutoLista { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}