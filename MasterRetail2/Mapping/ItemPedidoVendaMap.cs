using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rcky.MasterRetail2.Mapping
{
	public class ItemPedidoVendaMap : EntityTypeConfiguration<ItemPedidoVenda>
	{
        public ItemPedidoVendaMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ItemPedidoVendaId, t.ID_PDVD });

			// Properties
            //this.Property(t => t.ID_ITPV)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
				
            //this.Property(t => t.ID_PDVD)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
            //this.Property(t => t.TIPO_ITPV)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CONDICIONAL_ITPV)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.PADRAO_DESCONTO_ITPV)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.SELO_IPI_ITPV)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.QSELO_IPI_ITPV)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.ENQ_IPI_ITPV)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITPV)
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
				
            //this.Property(t => t.TISSQN_ITPV)
            //    .HasMaxLength(3);
				
            //// Table & Column Mappings
            //this.ToTable("ITENS_PEDIDO_VENDA");
            //this.Property(t => t.ID_ITPV).HasColumnName("ID_ITPV");
            //this.Property(t => t.ID_PDVD).HasColumnName("ID_PDVD");
            //this.Property(t => t.ValorProduto).HasColumnName("ID_VLPR");
            //this.Property(t => t.ID_PDLS).HasColumnName("ID_PDLS");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            //this.Property(t => t.DESC_NTOP_ITPV).HasColumnName("DESC_NTOP_ITPV");
            //this.Property(t => t.ID_ORIG).HasColumnName("ID_ORIG");
            //this.Property(t => t.ID_UF_OP_ITPV).HasColumnName("ID_UF_OP_ITPV");
            //this.Property(t => t.ID_SITB_ICMS).HasColumnName("ID_SITB_ICMS");
            //this.Property(t => t.ID_SITB_IPI).HasColumnName("ID_SITB_IPI");
            //this.Property(t => t.ID_SITB_PIS).HasColumnName("ID_SITB_PIS");
            //this.Property(t => t.ID_SITB_COFINS).HasColumnName("ID_SITB_COFINS");
            //this.Property(t => t.ID_MDPD).HasColumnName("ID_MDPD");
            //this.Property(t => t.ID_MDPD_ST).HasColumnName("ID_MDPD_ST");
            //this.Property(t => t.ID_MDSP).HasColumnName("ID_MDSP");
            //this.Property(t => t.ID_CID_ISSQN_ITPV).HasColumnName("ID_CID_ISSQN_ITPV");
            //this.Property(t => t.ITEM_ITPV).HasColumnName("ITEM_ITPV");
            //this.Property(t => t.TIPO_ITPV).HasColumnName("TIPO_ITPV");
            //this.Property(t => t.COMANDA_ITPV).HasColumnName("COMANDA_ITPV");
            //this.Property(t => t.HORA_ITPV).HasColumnName("HORA_ITPV");
            //this.Property(t => t.QTDE_ITPV).HasColumnName("QTDE_ITPV");
            //this.Property(t => t.FATURADO_ITPV).HasColumnName("FATURADO_ITPV");
            //this.Property(t => t.PRECO_ITPV).HasColumnName("PRECO_ITPV");
            //this.Property(t => t.DESCONTO_ITPV).HasColumnName("DESCONTO_ITPV");
            //this.Property(t => t.FRETE_ITPV).HasColumnName("FRETE_ITPV");
            //this.Property(t => t.SEGURO_ITPV).HasColumnName("SEGURO_ITPV");
            //this.Property(t => t.DESP_ACESSORIA_ITPV).HasColumnName("DESP_ACESSORIA_ITPV");
            //this.Property(t => t.CONDICIONAL_ITPV).HasColumnName("CONDICIONAL_ITPV");
            //this.Property(t => t.PROP_DESCONTO_ITPV).HasColumnName("PROP_DESCONTO_ITPV");
            //this.Property(t => t.PADRAO_DESCONTO_ITPV).HasColumnName("PADRAO_DESCONTO_ITPV");
            //this.Property(t => t.INDTOT_ITPV).HasColumnName("INDTOT_ITPV");
            //this.Property(t => t.BICMS_ITPV).HasColumnName("BICMS_ITPV");
            //this.Property(t => t.PICMS_ITPV).HasColumnName("PICMS_ITPV");
            //this.Property(t => t.ICMS_ITPV).HasColumnName("ICMS_ITPV");
            //this.Property(t => t.RICMS_ITPV).HasColumnName("RICMS_ITPV");
            //this.Property(t => t.BOPICMS_ITPV).HasColumnName("BOPICMS_ITPV");
            //this.Property(t => t.RICMSST_ITPV).HasColumnName("RICMSST_ITPV");
            //this.Property(t => t.MVA_ICMSST_ITPV).HasColumnName("MVA_ICMSST_ITPV");
            //this.Property(t => t.BICMSST_ITPV).HasColumnName("BICMSST_ITPV");
            //this.Property(t => t.PICMSST_ITPV).HasColumnName("PICMSST_ITPV");
            //this.Property(t => t.ICMSST_ITPV).HasColumnName("ICMSST_ITPV");
            //this.Property(t => t.BICMSST_UF_EMIT_ITPV).HasColumnName("BICMSST_UF_EMIT_ITPV");
            //this.Property(t => t.ICMSST_UF_EMIT_ITPV).HasColumnName("ICMSST_UF_EMIT_ITPV");
            //this.Property(t => t.BICMSST_UF_DEST_ITPV).HasColumnName("BICMSST_UF_DEST_ITPV");
            //this.Property(t => t.ICMSST_UF_DEST_ITPV).HasColumnName("ICMSST_UF_DEST_ITPV");
            //this.Property(t => t.BICMSST_ANT_ITPV).HasColumnName("BICMSST_ANT_ITPV");
            //this.Property(t => t.BICMSST_ANT_ITPV).HasColumnName("BICMSST_ANT_ITPV");
            //this.Property(t => t.PCREDICMS_ITPV).HasColumnName("PCREDICMS_ITPV");
            //this.Property(t => t.CREDICMS_ITPV).HasColumnName("CREDICMS_ITPV");
            //this.Property(t => t.SELO_IPI_ITPV).HasColumnName("SELO_IPI_ITPV");
            //this.Property(t => t.QSELO_IPI_ITPV).HasColumnName("QSELO_IPI_ITPV");
            //this.Property(t => t.ENQ_IPI_ITPV).HasColumnName("ENQ_IPI_ITPV");
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITPV).HasColumnName("CNPJ_PRODUTOR_IPI_ITPV");
            //this.Property(t => t.CALCULO_IPI).HasColumnName("CALCULO_IPI");
            //this.Property(t => t.BIPI_ITPV).HasColumnName("BIPI_ITPV");
            //this.Property(t => t.PIPI_ITPV).HasColumnName("PIPI_ITPV");
            //this.Property(t => t.QIPI_ITPV).HasColumnName("QIPI_ITPV");
            //this.Property(t => t.VIPI_ITPV).HasColumnName("VIPI_ITPV");
            //this.Property(t => t.IPI_ITPV).HasColumnName("IPI_ITPV");
            //this.Property(t => t.CALCULO_PIS).HasColumnName("CALCULO_PIS");
            //this.Property(t => t.BPIS_ITPV).HasColumnName("BPIS_ITPV");
            //this.Property(t => t.PPIS_ITPV).HasColumnName("PPIS_ITPV");
            //this.Property(t => t.VPIS_ITPV).HasColumnName("QPIS_ITPV");
            //this.Property(t => t.QPIS_ITPV).HasColumnName("VPIS_ITPV");
            //this.Property(t => t.PIS_ITPV).HasColumnName("PIS_ITPV");
            //this.Property(t => t.CALCULO_PISST).HasColumnName("CALCULO_PISST");
            //this.Property(t => t.BPISST_ITPV).HasColumnName("BPISST_ITPV");
            //this.Property(t => t.PPISST_ITPV).HasColumnName("PPISST_ITPV");
            //this.Property(t => t.QPISST_ITPV).HasColumnName("QPISST_ITPV");
            //this.Property(t => t.VPISST_ITPV).HasColumnName("VPISST_ITPV");
            //this.Property(t => t.PISST_ITPV).HasColumnName("PISST_ITPV");
            //this.Property(t => t.CALCULO_COFINS).HasColumnName("CALCULO_COFINS");
            //this.Property(t => t.BCOFINS_ITPV).HasColumnName("BCOFINS_ITPV");
            //this.Property(t => t.PCOFINS_ITPV).HasColumnName("PCOFINS_ITPV");
            //this.Property(t => t.QCOFINS_ITPV).HasColumnName("QCOFINS_ITPV");
            //this.Property(t => t.VCOFINS_ITPV).HasColumnName("VCOFINS_ITPV");
            //this.Property(t => t.COFINS_ITPV).HasColumnName("COFINS_ITPV");
            //this.Property(t => t.CALCULO_COFINSST).HasColumnName("CALCULO_COFINSST");
            //this.Property(t => t.BCOFINSST_ITPV).HasColumnName("BCOFINSST_ITPV");
            //this.Property(t => t.PCOFINSST_ITPV).HasColumnName("PCOFINSST_ITPV");
            //this.Property(t => t.QCOFINSST_ITPV).HasColumnName("QCOFINSST_ITPV");
            //this.Property(t => t.VCOFINSST_ITPV).HasColumnName("VCOFINSST_ITPV");
            //this.Property(t => t.COFINSST_ITPV).HasColumnName("COFINSST_ITPV");
            //this.Property(t => t.BII_ITPV).HasColumnName("BII_ITPV");
            //this.Property(t => t.ADUII_ITPV).HasColumnName("ADUII_ITPV");
            //this.Property(t => t.IOFII_ITPV).HasColumnName("IOFII_ITPV");
            //this.Property(t => t.II_ITPV).HasColumnName("II_ITPV");
            //this.Property(t => t.OBS_ITPV).HasColumnName("OBS_ITPV");
            //this.Property(t => t.INFO_FISCO_ITPV).HasColumnName("INFO_FISCO_ITPV");
            //this.Property(t => t.TISSQN_ITPV).HasColumnName("TISSQN_ITPV");
            //this.Property(t => t.BISSQNST_ITPV).HasColumnName("BISSQNST_ITPV");
            //this.Property(t => t.PISSQNST_ITPV).HasColumnName("PISSQNST_ITPV");
            //this.Property(t => t.ISSQN_ITPV).HasColumnName("ISSQN_ITPV");
            //this.Property(t => t.VLRMERC_ITPV).HasColumnName("VLRMERC_ITPV");
            //this.Property(t => t.VLRTOT_ITPV).HasColumnName("VLRTOT_ITPV");
            //this.Property(t => t.QTDE_FATURADA_ITPV).HasColumnName("QTDE_FATURADA_ITPV");
            //this.Property(t => t.QTDE_FATURAR_ITPV).HasColumnName("QTDE_FATURAR_ITPV");

            //// Relationships
            //this.HasOptional(t => t.LOCAIS_ESTOQUE)
            //    .WithMany(t => t.ITEM_PEDIDO_VENDA)
            //    .HasForeignKey(d => d.LocalEstoqueId);
				
            //this.HasRequired(t => t.PEDIDOS_VENDA)
            //    .WithMany(t => t.ITENS_PEDIDO_VENDA)
            //    .HasForeignKey(d => d.ID_PDVD);
				
            //this.HasOptional(t => t.Produto_LISTA)
            //    .WithMany(t => t.ITEM_PEDIDO_VENDA)
            //    .HasForeignKey(d => d.ID_PDLS);
				
            //this.HasOptional(t => t.VALORES_PRODUTO)
            //    .WithMany(t => t.ITEM_PEDIDO_VENDA)
            //    .HasForeignKey(d => d.ValorProduto);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.ITEM_PEDIDO_VENDA)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

