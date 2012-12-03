using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Produto
    {
        public Produto()
        {
            this.Arvores = new List<Arvore>();
            this.CodigosBarras = new List<CodigoBarras>();
            this.Equipamentos = new List<EquipamentoProduto>();
            this.EvolucoesCusto = new List<EvolucaoCusto>();
            this.Fornecedores = new List<FornecedorProduto>();
            this.Fotos = new List<FotoProduto>();
            this.ItensArvore = new List<ItemArvore>();
            this.ItensKit = new List<ItemKit>();
            this.ItensPromocao = new List<ItemPromocao>();
            this.ItensTecladoRapido = new List<ItemTecladoRapido>();
            this.Listas = new List<ProdutoLista>();
            this.Propriedades = new List<PropriedadeProduto>();
            this.TeclasMicroTerminal = new List<TeclaMicroTerminal>();
            this.Valores = new List<ValorProduto>();
            this.Lojas = new List<ProdutoLoja>();
        }

        public int ProdutoId { get; set; }
        public Nullable<int> GrupoProdutoId { get; set; }
        public Nullable<int> GrupoFaturamentoId { get; set; }
        public Nullable<int> COD_GRTP { get; set; }
        public Nullable<int> UnidadeId { get; set; }
        public Nullable<int> EmbalagemId { get; set; }
        public Nullable<int> FornecedorId { get; set; }
        public string Descricao { get; set; }
        public string DescricaoReduzida { get; set; }
        public Nullable<decimal> Custo { get; set; }
        public Nullable<decimal> Margem { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public Nullable<int> CodigoBalanca { get; set; }
        public Nullable<int> TeclaBalanca { get; set; }
        public Nullable<int> SetorBalandaId { get; set; }
        public string PesoCaixa { get; set; }
        public Nullable<int> Validade { get; set; }
        public string ClasseIcms { get; set; }
        public Nullable<decimal> Reducao { get; set; }
        public Nullable<int> CodigoTributacaoId { get; set; }
        public Nullable<int> PromocaoId { get; set; }
        public string Cf { get; set; }
        public Nullable<decimal> Icms { get; set; }
        public Nullable<decimal> IcmsSt { get; set; }
        public Nullable<decimal> Pis { get; set; }
        public Nullable<decimal> PisSt { get; set; }
        public Nullable<decimal> Cofins { get; set; }
        public Nullable<decimal> CofinsSt { get; set; }
        public Nullable<decimal> Ipi { get; set; }
        public Nullable<decimal> IpiPeso { get; set; }
        public Nullable<decimal> IpiSt { get; set; }
        public Nullable<decimal> Issqn { get; set; }
        public Nullable<decimal> IssqnSt { get; set; }
        public Nullable<decimal> Ii { get; set; }
        public Nullable<decimal> CoeficienteRoyalties { get; set; }
        public string ETIQMDPR_PROD { get; set; }
        public string ETIQENTR_PROD { get; set; }
        public string TipoVenda { get; set; }
        public Nullable<int> TipoEntrada { get; set; }
        public Nullable<int> TipoBaixa { get; set; }
        public Nullable<int> ServicoId { get; set; }
        public Nullable<decimal> PesoLiquido { get; set; }
        public Nullable<decimal> PesoBruto { get; set; }
        public Nullable<int> Largura { get; set; }
        public Nullable<int> Altura { get; set; }
        public Nullable<int> Comprimento { get; set; }
        public Nullable<decimal> EstoqueMinimo { get; set; }
        public Nullable<decimal> EstoqueMaximo { get; set; }
        public Nullable<decimal> QuantidadeEmbalagem { get; set; }
        public string Local { get; set; }
        public Nullable<int> NcmId { get; set; }
        public string Observacao { get; set; }
        public string AtivoString { get; set; }
        public bool Ativo
        {
            get { return AtivoString == "A"; }
            set { AtivoString = value ? "A" : "B"; }
        }
        public string ReceitaBalanca { get; set; }
        public Nullable<decimal> UnidadeConversao { get; set; }
        public Nullable<decimal> Comissao { get; set; }
        public Nullable<int> OrigemProdutoId { get; set; }
        public Nullable<int> ModalidadeProdutoId { get; set; }
        public Nullable<int> ModalidadeProdutoStId { get; set; }
        public Nullable<decimal> AliquotaBaseOperacaoPropria { get; set; }
        public Nullable<decimal> AliquotaCreditoSimplesNacional { get; set; }
        public Nullable<int> SituacaoTributariaIcmsId { get; set; }
        public Nullable<int> SituacaoTributariaCsosnId { get; set; }
        public Nullable<int> SituacaoTributariaIpiId { get; set; }
        public Nullable<int> SituacaoTributariaPisId { get; set; }
        public Nullable<int> SituacaoTributariaCofinsId { get; set; }
        public Nullable<int> MotivoDesoneracaoId { get; set; }
        public virtual ICollection<Arvore> Arvores { get; set; }
        public virtual ICollection<CodigoBarras> CodigosBarras { get; set; }
        public virtual CodigoTributacao CodigoTributacao { get; set; }
        public virtual ICollection<EquipamentoProduto> Equipamentos { get; set; }
        public virtual ICollection<EvolucaoCusto> EvolucoesCusto { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<FornecedorProduto> Fornecedores { get; set; }
        public virtual ICollection<FotoProduto> Fotos { get; set; }
        public virtual GrupoFaturamento GrupoFaturamento { get; set; }
        public virtual GrupoTributacaoProduto GrupoTributacao { get; set; }
        public virtual GrupoProduto Grupo { get; set; }
        public virtual ICollection<ItemArvore> ItensArvore { get; set; }
        public virtual ICollection<ItemKit> ItensKit { get; set; }
        public virtual ICollection<ItemPromocao> ItensPromocao { get; set; }
        public virtual ICollection<ItemTecladoRapido> ItensTecladoRapido { get; set; }
        public virtual ICollection<ProdutoLista> Listas { get; set; }
        public virtual ICollection<PropriedadeProduto> Propriedades { get; set; }
        public virtual ICollection<Acessorio> Acessorios { get; set; }
        public virtual ICollection<TeclaMicroTerminal> TeclasMicroTerminal { get; set; }
        public virtual ICollection<ValorProduto> Valores { get; set; }
        public virtual ICollection<ProdutoLoja> Lojas { get; set; }
        public virtual Promocao Promocao { get; set; }
        public virtual Servico Servico { get; set; }
        public virtual SetorBalanca SetorBalanca { get; set; }
        public virtual TipoMovimento TipoMovimentoBaixa { get; set; }
        public virtual TipoMovimento TipoMovimentoEntrada { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual Unidade Embalagem { get; set; }
    }
}