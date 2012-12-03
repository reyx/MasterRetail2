using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            // Primary Key
            this.HasKey(t => t.ProdutoId);

            // Properties
            this.Property(t => t.ProdutoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Descricao)
                .HasMaxLength(60);

            this.Property(t => t.DescricaoReduzida)
                .HasMaxLength(26);

            this.Property(t => t.PesoCaixa)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ClasseIcms)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Cf)
                .HasMaxLength(10);

            this.Property(t => t.ETIQMDPR_PROD)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ETIQENTR_PROD)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TipoVenda)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Local)
                .HasMaxLength(10);

            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            this.Property(t => t.ReceitaBalanca)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PRODUTOS");
            this.Property(t => t.ProdutoId).HasColumnName("COD_PROD");
            this.Property(t => t.GrupoProdutoId).HasColumnName("COD_GRPR");
            this.Property(t => t.GrupoFaturamentoId).HasColumnName("COD_GRFT");
            this.Property(t => t.UnidadeId).HasColumnName("ID_UNID");
            this.Property(t => t.EmbalagemId).HasColumnName("ID_UNID_EMB");
            this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            this.Property(t => t.Descricao).HasColumnName("DESC_PROD");
            this.Property(t => t.DescricaoReduzida).HasColumnName("DESCRED_PROD");
            this.Property(t => t.Custo).HasColumnName("CUSTO_PROD");
            this.Property(t => t.Margem).HasColumnName("MARGEM_PROD");
            this.Property(t => t.Preco).HasColumnName("PRECO_PROD");
            this.Property(t => t.CodigoBalanca).HasColumnName("CODBAL_PROD");
            this.Property(t => t.TeclaBalanca).HasColumnName("TECLABAL_PROD");
            this.Property(t => t.SetorBalandaId).HasColumnName("COD_STBL");
            this.Property(t => t.PesoCaixa).HasColumnName("PSCAIXA_PROD");
            this.Property(t => t.Validade).HasColumnName("VALIDADE_PROD");
            this.Property(t => t.ClasseIcms).HasColumnName("CLASSEICMS_PROD");
            this.Property(t => t.Reducao).HasColumnName("REDUCAO_PROD");
            this.Property(t => t.CodigoTributacaoId).HasColumnName("COD_CDTR");
            this.Property(t => t.PromocaoId).HasColumnName("COD_PROM");
            this.Property(t => t.Cf).HasColumnName("CF_PROD");
            this.Property(t => t.Icms).HasColumnName("ICMS_PROD");
            this.Property(t => t.IcmsSt).HasColumnName("ICMSST_PROD");
            this.Property(t => t.Pis).HasColumnName("PIS_PROD");
            this.Property(t => t.PisSt).HasColumnName("PISST_PROD");
            this.Property(t => t.Cofins).HasColumnName("COFINS_PROD");
            this.Property(t => t.CofinsSt).HasColumnName("COFINSST_PROD");
            this.Property(t => t.Ipi).HasColumnName("IPI_PROD");
            this.Property(t => t.IpiPeso).HasColumnName("IPIPESO_PROD");
            this.Property(t => t.IpiSt).HasColumnName("IPIST_PROD");
            this.Property(t => t.Issqn).HasColumnName("ISSQN_PROD");
            this.Property(t => t.IssqnSt).HasColumnName("ISSQNST_PROD");
            this.Property(t => t.Ii).HasColumnName("II_PROD");
            this.Property(t => t.CoeficienteRoyalties).HasColumnName("COEFROYA_PROD");
            this.Property(t => t.ETIQMDPR_PROD).HasColumnName("ETIQMDPR_PROD");
            this.Property(t => t.ETIQENTR_PROD).HasColumnName("ETIQENTR_PROD");
            this.Property(t => t.TipoVenda).HasColumnName("TIPOVENDA_PROD");
            this.Property(t => t.TipoEntrada).HasColumnName("TIPOENTR_PROD");
            this.Property(t => t.TipoBaixa).HasColumnName("TIPOBAIXA_PROD");
            this.Property(t => t.ServicoId).HasColumnName("ID_SERV");
            this.Property(t => t.PesoLiquido).HasColumnName("PESOLIQ_PROD");
            this.Property(t => t.PesoBruto).HasColumnName("PESOBRT_PROD");
            this.Property(t => t.Largura).HasColumnName("LARGURA_PROD");
            this.Property(t => t.Altura).HasColumnName("ALTURA_PROD");
            this.Property(t => t.Comprimento).HasColumnName("COMPR_PROD");
            this.Property(t => t.EstoqueMinimo).HasColumnName("ESTMIN_PROD");
            this.Property(t => t.EstoqueMaximo).HasColumnName("ESTMAX_PROD");
            this.Property(t => t.QuantidadeEmbalagem).HasColumnName("QTDEMB_PROD");
            this.Property(t => t.Local).HasColumnName("LOCAL_PROD");
            this.Property(t => t.NcmId).HasColumnName("ID_NCM");
            this.Property(t => t.Observacao).HasColumnName("OBS_PROD");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_PROD");
            this.Property(t => t.ReceitaBalanca).HasColumnName("RECEITABAL_PROD");
            this.Property(t => t.UnidadeConversao).HasColumnName("UNIDCONV_PROD");
            this.Property(t => t.Comissao).HasColumnName("COMISSAO_PROD");
            this.Property(t => t.OrigemProdutoId).HasColumnName("ID_ORIG");
            this.Property(t => t.ModalidadeProdutoId).HasColumnName("ID_MDPD_ICMS");
            this.Property(t => t.ModalidadeProdutoStId).HasColumnName("ID_MDPD_ICMSST");
            this.Property(t => t.AliquotaBaseOperacaoPropria).HasColumnName("PBASE_OPERACAO_PROPRIA_PROD");
            this.Property(t => t.AliquotaCreditoSimplesNacional).HasColumnName("PCRED_SIMPLES_NACIONAL_PROD");
            this.Property(t => t.SituacaoTributariaIcmsId).HasColumnName("ID_SITB_ICMS");
            this.Property(t => t.SituacaoTributariaCsosnId).HasColumnName("ID_SITB_CSOSN");
            this.Property(t => t.SituacaoTributariaIpiId).HasColumnName("ID_SITB_IPI");
            this.Property(t => t.SituacaoTributariaPisId).HasColumnName("ID_SITB_PIS");
            this.Property(t => t.SituacaoTributariaCofinsId).HasColumnName("ID_SITB_COFINS");
            this.Property(t => t.MotivoDesoneracaoId).HasColumnName("ID_MDSP");

            // Relationships
            this.HasOptional(t => t.CodigoTributacao)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.CodigoTributacaoId);

            this.HasOptional(t => t.Fornecedor)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.FornecedorId);

            this.HasOptional(t => t.GrupoFaturamento)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.GrupoFaturamentoId);

            this.HasOptional(t => t.GrupoTributacao)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.COD_GRTP);

            this.HasOptional(t => t.Grupo)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.GrupoProdutoId);

            this.HasOptional(t => t.Promocao)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.PromocaoId);

            this.HasOptional(t => t.Servico)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.ServicoId);

            this.HasOptional(t => t.SetorBalanca)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.SetorBalandaId);

            this.HasOptional(t => t.TipoMovimentoBaixa)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.TipoBaixa);

            this.HasOptional(t => t.TipoMovimentoEntrada)
                .WithMany(t => t.ProdutosAssociados)
                .HasForeignKey(d => d.TipoEntrada);

            this.HasOptional(t => t.Embalagem)
                .WithMany(t => t.Produtos)
                .HasForeignKey(d => d.EmbalagemId);

            this.HasOptional(t => t.Unidade)
                .WithMany(t => t.Embalagens)
                .HasForeignKey(d => d.UnidadeId);

        }
    }
}