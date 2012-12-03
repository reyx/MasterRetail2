using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class ItemEntradaMap : EntityTypeConfiguration<ItemEntrada>
	{
        public ItemEntradaMap()
		{
			// Primary Key
			this.HasKey(t => t.ItemEntradaId);

            //// Properties
            //this.Property(t => t.TIPO_ITEN)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CONDICIONAL_ITEN)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.PADRAO_DESCONTO_ITEN)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.SELO_IPI_ITEN)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.QSELO_IPI_ITEN)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.ENQ_IPI_ITEN)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITEN)
            //    .HasMaxLength(14);
				
            //this.Property(t => t.CALCULO_IPI)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CALCULO_PIS)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CALCULO_PISST)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CALCULO_COFINS)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CALCULO_COFINSST)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.TISSQN_ITEN)
            //    .HasMaxLength(3);
				
            //// Table & Column Mappings
            //this.ToTable("ITENS_ENTRADA");
            //this.Property(t => t.ID_ITEN).HasColumnName("ID_ITEN");
            //this.Property(t => t.ID_ENTR).HasColumnName("ID_ENTR");
            //this.Property(t => t.ValorProduto).HasColumnName("ID_VLPR");
            //this.Property(t => t.ID_PDLS).HasColumnName("ID_PDLS");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.ID_ORIG).HasColumnName("ID_ORIG");
            //this.Property(t => t.ID_UF_OP_ITEN).HasColumnName("ID_UF_OP_ITEN");
            //this.Property(t => t.ID_SITB_ICMS).HasColumnName("ID_SITB_ICMS");
            //this.Property(t => t.ID_SITB_IPI).HasColumnName("ID_SITB_IPI");
            //this.Property(t => t.ID_SITB_PIS).HasColumnName("ID_SITB_PIS");
            //this.Property(t => t.ID_SITB_COFINS).HasColumnName("ID_SITB_COFINS");
            //this.Property(t => t.ID_MDPD).HasColumnName("ID_MDPD");
            //this.Property(t => t.ID_MDPD_ST).HasColumnName("ID_MDPD_ST");
            //this.Property(t => t.ID_MDSP).HasColumnName("ID_MDSP");
            //this.Property(t => t.ID_CID_ISSQN_ITEN).HasColumnName("ID_CID_ISSQN_ITEN");
            //this.Property(t => t.ITEM_ITEN).HasColumnName("ITEM_ITEN");
            //this.Property(t => t.TIPO_ITEN).HasColumnName("TIPO_ITEN");
            //this.Property(t => t.COMANDA_ITEN).HasColumnName("COMANDA_ITEN");
            //this.Property(t => t.HORA_ITEN).HasColumnName("HORA_ITEN");
            //this.Property(t => t.QTDE_ITEN).HasColumnName("QTDE_ITEN");
            //this.Property(t => t.FATURADO_ITEN).HasColumnName("FATURADO_ITEN");
            //this.Property(t => t.PRECO_ITEN).HasColumnName("PRECO_ITEN");
            //this.Property(t => t.DESCONTO_ITEN).HasColumnName("DESCONTO_ITEN");
            //this.Property(t => t.FRETE_ITEN).HasColumnName("FRETE_ITEN");
            //this.Property(t => t.SEGURO_ITEN).HasColumnName("SEGURO_ITEN");
            //this.Property(t => t.DESP_ACESSORIA_ITEN).HasColumnName("DESP_ACESSORIA_ITEN");
            //this.Property(t => t.CONDICIONAL_ITEN).HasColumnName("CONDICIONAL_ITEN");
            //this.Property(t => t.PROP_DESCONTO_ITEN).HasColumnName("PROP_DESCONTO_ITEN");
            //this.Property(t => t.PADRAO_DESCONTO_ITEN).HasColumnName("PADRAO_DESCONTO_ITEN");
            //this.Property(t => t.INDTOT_ITEN).HasColumnName("INDTOT_ITEN");
            //this.Property(t => t.BICMS_ITEN).HasColumnName("BICMS_ITEN");
            //this.Property(t => t.PICMS_ITEN).HasColumnName("PICMS_ITEN");
            //this.Property(t => t.ICMS_ITEN).HasColumnName("ICMS_ITEN");
            //this.Property(t => t.RICMS_ITEN).HasColumnName("RICMS_ITEN");
            //this.Property(t => t.BOPICMS_ITEN).HasColumnName("BOPICMS_ITEN");
            //this.Property(t => t.RICMSST_ITEN).HasColumnName("RICMSST_ITEN");
            //this.Property(t => t.MVA_ICMSST_ITEN).HasColumnName("MVA_ICMSST_ITEN");
            //this.Property(t => t.BICMSST_ITEN).HasColumnName("BICMSST_ITEN");
            //this.Property(t => t.PICMSST_ITEN).HasColumnName("PICMSST_ITEN");
            //this.Property(t => t.ICMSST_ITEN).HasColumnName("ICMSST_ITEN");
            //this.Property(t => t.BICMSST_UF_EMIT_ITEN).HasColumnName("BICMSST_UF_EMIT_ITEN");
            //this.Property(t => t.ICMSST_UF_EMIT_ITEN).HasColumnName("ICMSST_UF_EMIT_ITEN");
            //this.Property(t => t.BICMSST_UF_DEST_ITEN).HasColumnName("BICMSST_UF_DEST_ITEN");
            //this.Property(t => t.ICMSST_UF_DEST_ITEN).HasColumnName("ICMSST_UF_DEST_ITEN");
            //this.Property(t => t.BICMSST_ANT_ITEN).HasColumnName("BICMSST_ANT_ITEN");
            //this.Property(t => t.ICMSST_ANT_ITEN).HasColumnName("ICMSST_ANT_ITEN");
            //this.Property(t => t.SELO_IPI_ITEN).HasColumnName("SELO_IPI_ITEN");
            //this.Property(t => t.QSELO_IPI_ITEN).HasColumnName("QSELO_IPI_ITEN");
            //this.Property(t => t.ENQ_IPI_ITEN).HasColumnName("ENQ_IPI_ITEN");
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITEN).HasColumnName("CNPJ_PRODUTOR_IPI_ITEN");
            //this.Property(t => t.CALCULO_IPI).HasColumnName("CALCULO_IPI");
            //this.Property(t => t.BIPI_ITEN).HasColumnName("BIPI_ITEN");
            //this.Property(t => t.PIPI_ITEN).HasColumnName("PIPI_ITEN");
            //this.Property(t => t.QIPI_ITEN).HasColumnName("QIPI_ITEN");
            //this.Property(t => t.VIPI_ITEN).HasColumnName("VIPI_ITEN");
            //this.Property(t => t.IPI_ITEN).HasColumnName("IPI_ITEN");
            //this.Property(t => t.CALCULO_PIS).HasColumnName("CALCULO_PIS");
            //this.Property(t => t.BPIS_ITEN).HasColumnName("BPIS_ITEN");
            //this.Property(t => t.PPIS_ITEN).HasColumnName("PPIS_ITEN");
            //this.Property(t => t.QPIS_ITEN).HasColumnName("QPIS_ITEN");
            //this.Property(t => t.PIS_ITEN).HasColumnName("PIS_ITEN");
            //this.Property(t => t.CALCULO_PISST).HasColumnName("CALCULO_PISST");
            //this.Property(t => t.BPISST_ITEN).HasColumnName("BPISST_ITEN");
            //this.Property(t => t.PPISST_ITEN).HasColumnName("PPISST_ITEN");
            //this.Property(t => t.QPISST_ITEN).HasColumnName("QPISST_ITEN");
            //this.Property(t => t.PISST_ITEN).HasColumnName("PISST_ITEN");
            //this.Property(t => t.CALCULO_COFINS).HasColumnName("CALCULO_COFINS");
            //this.Property(t => t.BCOFINS_ITEN).HasColumnName("BCOFINS_ITEN");
            //this.Property(t => t.PCOFINS_ITEN).HasColumnName("PCOFINS_ITEN");
            //this.Property(t => t.QCOFINS_ITEN).HasColumnName("QCOFINS_ITEN");
            //this.Property(t => t.COFINS_ITEN).HasColumnName("COFINS_ITEN");
            //this.Property(t => t.CALCULO_COFINSST).HasColumnName("CALCULO_COFINSST");
            //this.Property(t => t.BCOFINSST_ITEN).HasColumnName("BCOFINSST_ITEN");
            //this.Property(t => t.PCOFINSST_ITEN).HasColumnName("PCOFINSST_ITEN");
            //this.Property(t => t.QCOFINSST_ITEN).HasColumnName("QCOFINSST_ITEN");
            //this.Property(t => t.COFINSST_ITEN).HasColumnName("COFINSST_ITEN");
            //this.Property(t => t.BII_ITEN).HasColumnName("BII_ITEN");
            //this.Property(t => t.ADUII_ITEN).HasColumnName("ADUII_ITEN");
            //this.Property(t => t.IOFII_ITEN).HasColumnName("IOFII_ITEN");
            //this.Property(t => t.II_ITEN).HasColumnName("II_ITEN");
            //this.Property(t => t.OBS_ITEN).HasColumnName("OBS_ITEN");
            //this.Property(t => t.TISSQN_ITEN).HasColumnName("TISSQN_ITEN");
            //this.Property(t => t.BISSQNST_ITEN).HasColumnName("BISSQNST_ITEN");
            //this.Property(t => t.PISSQNST_ITEN).HasColumnName("PISSQNST_ITEN");
            //this.Property(t => t.ISSQN_ITEN).HasColumnName("ISSQN_ITEN");
            //this.Property(t => t.VLRMERC_ITEN).HasColumnName("VLRMERC_ITEN");
            //this.Property(t => t.VLRTOT_ITEN).HasColumnName("VLRTOT_ITEN");
            //this.Property(t => t.QTDE_FATURADA_ITEN).HasColumnName("QTDE_FATURADA_ITEN");
            //this.Property(t => t.QTDE_FATURAR_ITEN).HasColumnName("QTDE_FATURAR_ITEN");

            //// Relationships
            //this.HasRequired(t => t.Entrada)
            //    .WithMany(t => t.ItensEntrada)
            //    .HasForeignKey(d => d.EntradaId);
				
            //this.HasOptional(t => t.LOCAIS_ESTOQUE)
            //    .WithMany(t => t.ITEM_ENTRADA)
            //    .HasForeignKey(d => d.LocalEstoqueId);
				
            //this.HasOptional(t => t.Produto_LISTA)
            //    .WithMany(t => t.ITEM_ENTRADA)
            //    .HasForeignKey(d => d.ID_PDLS);
				
            //this.HasOptional(t => t.VALORES_PRODUTO)
            //    .WithMany(t => t.ITEM_ENTRADA)
            //    .HasForeignKey(d => d.ValorProduto);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.ITEM_ENTRADA)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

