using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class ItemNotaFiscalMap : EntityTypeConfiguration<ItemNotaFiscal>
	{
        public ItemNotaFiscalMap()
		{
			// Primary Key
			this.HasKey(t => t.ItemNotaFiscalId);

			// Properties
			this.Property(t => t.TIPO_ITNF)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.CONDICIONAL_ITNF)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.PADRAO_DESCONTO_ITNF)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.SELO_IPI_ITNF)
				.HasMaxLength(45);
				
			this.Property(t => t.QSELO_IPI_ITNF)
				.HasMaxLength(45);
				
			this.Property(t => t.ENQ_IPI_ITNF)
				.HasMaxLength(45);
				
			this.Property(t => t.CNPJ_PRODUTOR_IPI_ITNF)
				.HasMaxLength(14);
				
			this.Property(t => t.CALCULO_IPI)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.CALCULO_PIS)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.CALCULO_PISST)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.CALCULO_COFINS)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.CALCULO_COFINSST)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.TISSQN_ITNF)
				.HasMaxLength(3);
				
			// Table & Column Mappings
            this.ToTable("ITENS_NOTA_FISCAL");
            //this.Property(t => t.ID_ITNF).HasColumnName("ID_ITNF");
            //this.Property(t => t.ID_NF).HasColumnName("ID_NF");
            //this.Property(t => t.ValorProduto).HasColumnName("ID_VLPR");
            //this.Property(t => t.ID_PDLS).HasColumnName("ID_PDLS");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.ID_ORIG).HasColumnName("ID_ORIG");
            //this.Property(t => t.ID_UF_OP_ITNF).HasColumnName("ID_UF_OP_ITNF");
            //this.Property(t => t.ID_SITB_ICMS).HasColumnName("ID_SITB_ICMS");
            //this.Property(t => t.ID_SITB_IPI).HasColumnName("ID_SITB_IPI");
            //this.Property(t => t.ID_SITB_PIS).HasColumnName("ID_SITB_PIS");
            //this.Property(t => t.ID_SITB_COFINS).HasColumnName("ID_SITB_COFINS");
            //this.Property(t => t.ID_MDPD).HasColumnName("ID_MDPD");
            //this.Property(t => t.ID_MDPD_ST).HasColumnName("ID_MDPD_ST");
            //this.Property(t => t.ID_MDSP).HasColumnName("ID_MDSP");
            //this.Property(t => t.ID_CID_ISSQN_ITNF).HasColumnName("ID_CID_ISSQN_ITNF");
            //this.Property(t => t.ITEM_ITNF).HasColumnName("ITEM_ITNF");
            //this.Property(t => t.TIPO_ITNF).HasColumnName("TIPO_ITNF");
            //this.Property(t => t.COMANDA_ITNF).HasColumnName("COMANDA_ITNF");
            //this.Property(t => t.HORA_ITNF).HasColumnName("HORA_ITNF");
            //this.Property(t => t.QTDE_ITNF).HasColumnName("QTDE_ITNF");
            //this.Property(t => t.FATURADO_ITNF).HasColumnName("FATURADO_ITNF");
            //this.Property(t => t.PRECO_ITNF).HasColumnName("PRECO_ITNF");
            //this.Property(t => t.DESCONTO_ITNF).HasColumnName("DESCONTO_ITNF");
            //this.Property(t => t.FRETE_ITNF).HasColumnName("FRETE_ITNF");
            //this.Property(t => t.SEGURO_ITNF).HasColumnName("SEGURO_ITNF");
            //this.Property(t => t.DESP_ACESSORIA_ITNF).HasColumnName("DESP_ACESSORIA_ITNF");
            //this.Property(t => t.CONDICIONAL_ITNF).HasColumnName("CONDICIONAL_ITNF");
            //this.Property(t => t.PROP_DESCONTO_ITNF).HasColumnName("PROP_DESCONTO_ITNF");
            //this.Property(t => t.PADRAO_DESCONTO_ITNF).HasColumnName("PADRAO_DESCONTO_ITNF");
            //this.Property(t => t.INDTOT_ITNF).HasColumnName("INDTOT_ITNF");
            //this.Property(t => t.BICMS_ITNF).HasColumnName("BICMS_ITNF");
            //this.Property(t => t.PICMS_ITNF).HasColumnName("PICMS_ITNF");
            //this.Property(t => t.ICMS_ITNF).HasColumnName("ICMS_ITNF");
            //this.Property(t => t.RICMS_ITNF).HasColumnName("RICMS_ITNF");
            //this.Property(t => t.BOPICMS_ITNF).HasColumnName("BOPICMS_ITNF");
            //this.Property(t => t.RICMSST_ITNF).HasColumnName("RICMSST_ITNF");
            //this.Property(t => t.MVA_ICMSST_ITNF).HasColumnName("MVA_ICMSST_ITNF");
            //this.Property(t => t.BICMSST_ITNF).HasColumnName("BICMSST_ITNF");
            //this.Property(t => t.PICMSST_ITNF).HasColumnName("PICMSST_ITNF");
            //this.Property(t => t.ICMSST_ITNF).HasColumnName("ICMSST_ITNF");
            //this.Property(t => t.BICMSST_UF_EMIT_ITNF).HasColumnName("BICMSST_UF_EMIT_ITNF");
            //this.Property(t => t.ICMSST_UF_EMIT_ITNF).HasColumnName("ICMSST_UF_EMIT_ITNF");
            //this.Property(t => t.BICMSST_UF_DEST_ITNF).HasColumnName("BICMSST_UF_DEST_ITNF");
            //this.Property(t => t.ICMSST_UF_DEST_ITNF).HasColumnName("ICMSST_UF_DEST_ITNF");
            //this.Property(t => t.BICMSST_ANT_ITNF).HasColumnName("BICMSST_ANT_ITNF");
            //this.Property(t => t.ICMSST_ANT_ITNF).HasColumnName("ICMSST_ANT_ITNF");
            //this.Property(t => t.SELO_IPI_ITNF).HasColumnName("SELO_IPI_ITNF");
            //this.Property(t => t.QSELO_IPI_ITNF).HasColumnName("QSELO_IPI_ITNF");
            //this.Property(t => t.ENQ_IPI_ITNF).HasColumnName("ENQ_IPI_ITNF");
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITNF).HasColumnName("CNPJ_PRODUTOR_IPI_ITNF");
            //this.Property(t => t.CALCULO_IPI).HasColumnName("CALCULO_IPI");
            //this.Property(t => t.BIPI_ITNF).HasColumnName("BIPI_ITNF");
            //this.Property(t => t.PIPI_ITNF).HasColumnName("PIPI_ITNF");
            //this.Property(t => t.QIPI_ITNF).HasColumnName("QIPI_ITNF");
            //this.Property(t => t.VIPI_ITNF).HasColumnName("VIPI_ITNF");
            //this.Property(t => t.IPI_ITNF).HasColumnName("IPI_ITNF");
            //this.Property(t => t.CALCULO_PIS).HasColumnName("CALCULO_PIS");
            //this.Property(t => t.BPIS_ITNF).HasColumnName("BPIS_ITNF");
            //this.Property(t => t.PPIS_ITNF).HasColumnName("PPIS_ITNF");
            //this.Property(t => t.QPIS_ITNF).HasColumnName("QPIS_ITNF");
            //this.Property(t => t.PIS_ITNF).HasColumnName("PIS_ITNF");
            //this.Property(t => t.CALCULO_PISST).HasColumnName("CALCULO_PISST");
            //this.Property(t => t.BPISST_ITNF).HasColumnName("BPISST_ITNF");
            //this.Property(t => t.PPISST_ITNF).HasColumnName("PPISST_ITNF");
            //this.Property(t => t.QPISST_ITNF).HasColumnName("QPISST_ITNF");
            //this.Property(t => t.PISST_ITNF).HasColumnName("PISST_ITNF");
            //this.Property(t => t.CALCULO_COFINS).HasColumnName("CALCULO_COFINS");
            //this.Property(t => t.BCOFINS_ITNF).HasColumnName("BCOFINS_ITNF");
            //this.Property(t => t.PCOFINS_ITNF).HasColumnName("PCOFINS_ITNF");
            //this.Property(t => t.QCOFINS_ITNF).HasColumnName("QCOFINS_ITNF");
            //this.Property(t => t.COFINS_ITNF).HasColumnName("COFINS_ITNF");
            //this.Property(t => t.CALCULO_COFINSST).HasColumnName("CALCULO_COFINSST");
            //this.Property(t => t.BCOFINSST_ITNF).HasColumnName("BCOFINSST_ITNF");
            //this.Property(t => t.PCOFINSST_ITNF).HasColumnName("PCOFINSST_ITNF");
            //this.Property(t => t.QCOFINSST_ITNF).HasColumnName("QCOFINSST_ITNF");
            //this.Property(t => t.COFINSST_ITNF).HasColumnName("COFINSST_ITNF");
            //this.Property(t => t.BII_ITNF).HasColumnName("BII_ITNF");
            //this.Property(t => t.ADUII_ITNF).HasColumnName("ADUII_ITNF");
            //this.Property(t => t.IOFII_ITNF).HasColumnName("IOFII_ITNF");
            //this.Property(t => t.II_ITNF).HasColumnName("II_ITNF");
            //this.Property(t => t.OBS_ITNF).HasColumnName("OBS_ITNF");
            //this.Property(t => t.TISSQN_ITNF).HasColumnName("TISSQN_ITNF");
            //this.Property(t => t.BISSQNST_ITNF).HasColumnName("BISSQNST_ITNF");
            //this.Property(t => t.PISSQNST_ITNF).HasColumnName("PISSQNST_ITNF");
            //this.Property(t => t.ISSQN_ITNF).HasColumnName("ISSQN_ITNF");
            //this.Property(t => t.VLRMERC_ITNF).HasColumnName("VLRMERC_ITNF");
            //this.Property(t => t.VLRTOT_ITNF).HasColumnName("VLRTOT_ITNF");
            //this.Property(t => t.QTDE_FATURADA_ITNF).HasColumnName("QTDE_FATURADA_ITNF");
            //this.Property(t => t.QTDE_FATURAR_ITNF).HasColumnName("QTDE_FATURAR_ITNF");

            //// Relationships
            //this.HasOptional(t => t.LOCAIS_ESTOQUE)
            //    .WithMany(t => t.ITEM_NOTA_FISCAL)
            //    .HasForeignKey(d => d.LocalEstoqueId);
				
            //this.HasRequired(t => t.NOTAS_FISCAIS)
            //    .WithMany(t => t.ITEM_NOTA_FISCAL)
            //    .HasForeignKey(d => d.ID_NF);
				
            //this.HasOptional(t => t.Produto_LISTA)
            //    .WithMany(t => t.ITEM_NOTA_FISCAL)
            //    .HasForeignKey(d => d.ID_PDLS);
				
            //this.HasOptional(t => t.VALORES_PRODUTO)
            //    .WithMany(t => t.ITEM_NOTA_FISCAL)
            //    .HasForeignKey(d => d.ValorProduto);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.ITEM_NOTA_FISCAL)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

