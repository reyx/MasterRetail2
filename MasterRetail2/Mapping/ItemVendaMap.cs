using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
	public class ItemVendaMap : EntityTypeConfiguration<ItemVenda>
	{
        public ItemVendaMap()
		{
			// Primary Key
			this.HasKey(t => t.ItemVendaId);

			// Properties
            //this.Property(t => t.ENTREGUE_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.OICMS_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.MICMS_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(2);
				
            //this.Property(t => t.SICMS_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TICMS_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TICMSST_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TPIS_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TPISST_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TCOFINS_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TCOFINSST_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TIPI_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TIPIST_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TISSQN_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.TISSQNST_ITVD)
            //    .HasMaxLength(3);
				
            //this.Property(t => t.MOTDESICMS_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(2);
				
            //this.Property(t => t.MICMSST_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(2);
				
            //this.Property(t => t.SCOFINS_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(2);
				
            //this.Property(t => t.SPIS_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(2);
				
            //this.Property(t => t.SIPI_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(2);
				
            //this.Property(t => t.SELOIPI_ITVD)
            //    .HasMaxLength(60);
				
            //this.Property(t => t.ENQIPI_ITVD)
            //    .HasMaxLength(5);
				
            //this.Property(t => t.CENQIPI_ITVD)
            //    .HasMaxLength(5);
				
            //this.Property(t => t.CNPJIPI_ITVD)
            //    .IsFixedLength()
            //    .HasMaxLength(14);
				
            //this.Property(t => t.INFOADI_ITVD)
            //    .HasMaxLength(255);
				
            //// Table & Column Mappings
            //this.ToTable("ITENS_VENDA");
            //this.Property(t => t.ID_ITVD).HasColumnName("ID_ITVD");
            //this.Property(t => t.ValorProduto).HasColumnName("ID_VLPR");
            //this.Property(t => t.ID_VDA).HasColumnName("ID_VDA");
            //this.Property(t => t.ID_ITNF).HasColumnName("ID_ITNF");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.ID_PDLS).HasColumnName("ID_PDLS");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.ITEM_ITVD).HasColumnName("ITEM_ITVD");
            //this.Property(t => t.QTDE_ITVD).HasColumnName("QTDE_ITVD");
            //this.Property(t => t.PRECO_ITVD).HasColumnName("PRECO_ITVD");
            //this.Property(t => t.ENTREGUE_ITVD).HasColumnName("ENTREGUE_ITVD");
            //this.Property(t => t.QTDEENT_ITVD).HasColumnName("QTDEENT_ITVD");
            //this.Property(t => t.COMANDA_ITVD).HasColumnName("COMANDA_ITVD");
            //this.Property(t => t.HORA_ITVD).HasColumnName("HORA_ITVD");
            //this.Property(t => t.DESCONTO_ITVD).HasColumnName("DESCONTO_ITVD");
            //this.Property(t => t.SEGURO_ITVD).HasColumnName("SEGURO_ITVD");
            //this.Property(t => t.FRETE_ITVD).HasColumnName("FRETE_ITVD");
            //this.Property(t => t.DESP_ACESSORIA_ITVD).HasColumnName("DESP_ACESSORIA_ITVD");
            //this.Property(t => t.ICMS_ITVD).HasColumnName("ICMS_ITVD");
            //this.Property(t => t.BICMS_ITVD).HasColumnName("BICMS_ITVD");
            //this.Property(t => t.OICMS_ITVD).HasColumnName("OICMS_ITVD");
            //this.Property(t => t.MICMS_ITVD).HasColumnName("MICMS_ITVD");
            //this.Property(t => t.PICMS_ITVD).HasColumnName("PICMS_ITVD");
            //this.Property(t => t.QICMS_ITVD).HasColumnName("QICMS_ITVD");
            //this.Property(t => t.SICMS_ITVD).HasColumnName("SICMS_ITVD");
            //this.Property(t => t.TICMS_ITVD).HasColumnName("TICMS_ITVD");
            //this.Property(t => t.VICMS_ITVD).HasColumnName("VICMS_ITVD");
            //this.Property(t => t.BICMSST_ITVD).HasColumnName("BICMSST_ITVD");
            //this.Property(t => t.ICMSST_ITVD).HasColumnName("ICMSST_ITVD");
            //this.Property(t => t.PICMSST_ITVD).HasColumnName("PICMSST_ITVD");
            //this.Property(t => t.QICMSST_ITVD).HasColumnName("QICMSST_ITVD");
            //this.Property(t => t.TICMSST_ITVD).HasColumnName("TICMSST_ITVD");
            //this.Property(t => t.VICMSST_ITVD).HasColumnName("VICMSST_ITVD");
            //this.Property(t => t.PIS_ITVD).HasColumnName("PIS_ITVD");
            //this.Property(t => t.BPIS_ITVD).HasColumnName("BPIS_ITVD");
            //this.Property(t => t.PPIS_ITVD).HasColumnName("PPIS_ITVD");
            //this.Property(t => t.QPIS_ITVD).HasColumnName("QPIS_ITVD");
            //this.Property(t => t.TPIS_ITVD).HasColumnName("TPIS_ITVD");
            //this.Property(t => t.VPIS_ITVD).HasColumnName("VPIS_ITVD");
            //this.Property(t => t.PISST_ITVD).HasColumnName("PISST_ITVD");
            //this.Property(t => t.BPISST_ITVD).HasColumnName("BPISST_ITVD");
            //this.Property(t => t.PPISST_ITVD).HasColumnName("PPISST_ITVD");
            //this.Property(t => t.QPISST_ITVD).HasColumnName("QPISST_ITVD");
            //this.Property(t => t.VPISST_ITVD).HasColumnName("VPISST_ITVD");
            //this.Property(t => t.TPISST_ITVD).HasColumnName("TPISST_ITVD");
            //this.Property(t => t.COFINS_ITVD).HasColumnName("COFINS_ITVD");
            //this.Property(t => t.PCOFINS_ITVD).HasColumnName("PCOFINS_ITVD");
            //this.Property(t => t.QCOFINS_ITVD).HasColumnName("QCOFINS_ITVD");
            //this.Property(t => t.VCOFINS_ITVD).HasColumnName("VCOFINS_ITVD");
            //this.Property(t => t.BCOFINS_ITVD).HasColumnName("BCOFINS_ITVD");
            //this.Property(t => t.TCOFINS_ITVD).HasColumnName("TCOFINS_ITVD");
            //this.Property(t => t.COFINSST_ITVD).HasColumnName("COFINSST_ITVD");
            //this.Property(t => t.PCOFINSST_ITVD).HasColumnName("PCOFINSST_ITVD");
            //this.Property(t => t.QCOFINSST_ITVD).HasColumnName("QCOFINSST_ITVD");
            //this.Property(t => t.VCOFINSST_ITVD).HasColumnName("VCOFINSST_ITVD");
            //this.Property(t => t.BCOFINSST_ITVD).HasColumnName("BCOFINSST_ITVD");
            //this.Property(t => t.TCOFINSST_ITVD).HasColumnName("TCOFINSST_ITVD");
            //this.Property(t => t.IPI_ITVD).HasColumnName("IPI_ITVD");
            //this.Property(t => t.PIPI_ITVD).HasColumnName("PIPI_ITVD");
            //this.Property(t => t.QIPI_ITVD).HasColumnName("QIPI_ITVD");
            //this.Property(t => t.VIPI_ITVD).HasColumnName("VIPI_ITVD");
            //this.Property(t => t.BIPI_ITVD).HasColumnName("BIPI_ITVD");
            //this.Property(t => t.TIPI_ITVD).HasColumnName("TIPI_ITVD");
            //this.Property(t => t.IPIST_ITVD).HasColumnName("IPIST_ITVD");
            //this.Property(t => t.PIPIST_ITVD).HasColumnName("PIPIST_ITVD");
            //this.Property(t => t.QIPIST_ITVD).HasColumnName("QIPIST_ITVD");
            //this.Property(t => t.VIPIST_ITVD).HasColumnName("VIPIST_ITVD");
            //this.Property(t => t.BIPIST_ITVD).HasColumnName("BIPIST_ITVD");
            //this.Property(t => t.TIPIST_ITVD).HasColumnName("TIPIST_ITVD");
            //this.Property(t => t.ISSQN_ITVD).HasColumnName("ISSQN_ITVD");
            //this.Property(t => t.PISSQN_ITVD).HasColumnName("PISSQN_ITVD");
            //this.Property(t => t.QISSQN_ITVD).HasColumnName("QISSQN_ITVD");
            //this.Property(t => t.VISSQN_ITVD).HasColumnName("VISSQN_ITVD");
            //this.Property(t => t.BISSQN_ITVD).HasColumnName("BISSQN_ITVD");
            //this.Property(t => t.TISSQN_ITVD).HasColumnName("TISSQN_ITVD");
            //this.Property(t => t.ISSQNST_ITVD).HasColumnName("ISSQNST_ITVD");
            //this.Property(t => t.PISSQNST_ITVD).HasColumnName("PISSQNST_ITVD");
            //this.Property(t => t.QISSQNST_ITVD).HasColumnName("QISSQNST_ITVD");
            //this.Property(t => t.VISSQNST_ITVD).HasColumnName("VISSQNST_ITVD");
            //this.Property(t => t.BISSQNST_ITVD).HasColumnName("BISSQNST_ITVD");
            //this.Property(t => t.TISSQNST_ITVD).HasColumnName("TISSQNST_ITVD");
            //this.Property(t => t.RICMS_ITVD).HasColumnName("RICMS_ITVD");
            //this.Property(t => t.ROPICMS_ITVD).HasColumnName("ROPICMS_ITVD");
            //this.Property(t => t.MOTDESICMS_ITVD).HasColumnName("MOTDESICMS_ITVD");
            //this.Property(t => t.PCREDICMS_ITVD).HasColumnName("PCREDICMS_ITVD");
            //this.Property(t => t.CREDITOICMS_ITVD).HasColumnName("CREDITOICMS_ITVD");
            //this.Property(t => t.BICMSRETIDO_ITVD).HasColumnName("BICMSRETIDO_ITVD");
            //this.Property(t => t.ICMSRETIDO_ITVD).HasColumnName("ICMSRETIDO_ITVD");
            //this.Property(t => t.MICMSST_ITVD).HasColumnName("MICMSST_ITVD");
            //this.Property(t => t.RICMSST_ITVD).HasColumnName("RICMSST_ITVD");
            //this.Property(t => t.MVAICMSST_ITVD).HasColumnName("MVAICMSST_ITVD");
            //this.Property(t => t.ICMSST_ID_UF_ITVD).HasColumnName("ICMSST_ID_UF_ITVD");
            //this.Property(t => t.BICMSST_UF_REM_ITVD).HasColumnName("BICMSST_UF_REM_ITVD");
            //this.Property(t => t.ICMSST_UF_REM_ITVD).HasColumnName("ICMSST_UF_REM_ITVD");
            //this.Property(t => t.BICMSST_UF_DEST_ITVD).HasColumnName("BICMSST_UF_DEST_ITVD");
            //this.Property(t => t.ICMSST_UF_DEST_ITVD).HasColumnName("ICMSST_UF_DEST_ITVD");
            //this.Property(t => t.BICMSST_RETIDO_ITVD).HasColumnName("BICMSST_RETIDO_ITVD");
            //this.Property(t => t.ICMSST_RETIDO_ITVD).HasColumnName("ICMSST_RETIDO_ITVD");
            //this.Property(t => t.OPICMS_ITVD).HasColumnName("OPICMS_ITVD");
            //this.Property(t => t.SCOFINS_ITVD).HasColumnName("SCOFINS_ITVD");
            //this.Property(t => t.SPIS_ITVD).HasColumnName("SPIS_ITVD");
            //this.Property(t => t.IPIPESO_ITVD).HasColumnName("IPIPESO_ITVD");
            //this.Property(t => t.SIPI_ITVD).HasColumnName("SIPI_ITVD");
            //this.Property(t => t.SELOIPI_ITVD).HasColumnName("SELOIPI_ITVD");
            //this.Property(t => t.QSELOIPI_ITVD).HasColumnName("QSELOIPI_ITVD");
            //this.Property(t => t.ENQIPI_ITVD).HasColumnName("ENQIPI_ITVD");
            //this.Property(t => t.CENQIPI_ITVD).HasColumnName("CENQIPI_ITVD");
            //this.Property(t => t.CNPJIPI_ITVD).HasColumnName("CNPJIPI_ITVD");
            //this.Property(t => t.BII_ITVD).HasColumnName("BII_ITVD");
            //this.Property(t => t.DESPADUII_ITVD).HasColumnName("DESPADUII_ITVD");
            //this.Property(t => t.IOFII_ITVD).HasColumnName("IOFII_ITVD");
            //this.Property(t => t.II_ITVD).HasColumnName("II_ITVD");
            //this.Property(t => t.ID_CID_ISSQN_ITVD).HasColumnName("ID_CID_ISSQN_ITVD");
            //this.Property(t => t.VLRMERC_ITVD).HasColumnName("VLRMERC_ITVD");
            //this.Property(t => t.VLRTOT_ITVD).HasColumnName("VLRTOT_ITVD");
            //this.Property(t => t.INDTOT_ITVD).HasColumnName("INDTOT_ITVD");
            //this.Property(t => t.INFOADI_ITVD).HasColumnName("INFOADI_ITVD");

            //// Relationships
            //this.HasOptional(t => t.ITEM_NOTA_FISCAL)
            //    .WithMany(t => t.ITEM_VENDA)
            //    .HasForeignKey(d => d.ID_ITNF);
				
            //this.HasOptional(t => t.Produto_LISTA)
            //    .WithMany(t => t.ITEM_VENDA)
            //    .HasForeignKey(d => d.ID_PDLS);
				
            //this.HasRequired(t => t.VALORES_PRODUTO)
            //    .WithMany(t => t.ITEM_VENDA)
            //    .HasForeignKey(d => d.ValorProduto);
				
            //this.HasOptional(t => t.VENDA)
            //    .WithMany(t => t.ITENS_VENDA)
            //    .HasForeignKey(d => d.ID_VDA);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.ITEM_VENDA)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

