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
	public class ItemPedidoCompraMap : EntityTypeConfiguration<ItemPedidoCompra>
	{
        public ItemPedidoCompraMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ItemPedidoCompraId, t.ID_PDCP });

            //// Properties
            //this.Property(t => t.ID_ITPC)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
				
            //this.Property(t => t.ID_PDCP)

            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
            //this.Property(t => t.TIPO_ITPC)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CONDICIONAL_ITPC)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.PADRAO_DESCONTO_ITPC)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.SELO_IPI_ITPC)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.QSELO_IPI_ITPC)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.ENQ_IPI_ITPC)
            //    .HasMaxLength(45);
				
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITPC)
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
				
            //this.Property(t => t.TISSQN_ITPC)
            //    .HasMaxLength(3);
				
            //// Table & Column Mappings
            //this.ToTable("ITENS_PEDIDO_COMPRA");
            //this.Property(t => t.ID_ITPC).HasColumnName("ID_ITPC");
            //this.Property(t => t.ID_PDCP).HasColumnName("ID_PDCP");
            //this.Property(t => t.ValorProduto).HasColumnName("ID_VLPR");
            //this.Property(t => t.ID_PDLS).HasColumnName("ID_PDLS");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.LocalEstoqueId).HasColumnName("COD_LCES");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.ID_ORIG).HasColumnName("ID_ORIG");
            //this.Property(t => t.ID_UF_OP_ITPC).HasColumnName("ID_UF_OP_ITPC");
            //this.Property(t => t.ID_SITB_ICMS).HasColumnName("ID_SITB_ICMS");
            //this.Property(t => t.ID_SITB_IPI).HasColumnName("ID_SITB_IPI");
            //this.Property(t => t.ID_SITB_PIS).HasColumnName("ID_SITB_PIS");
            //this.Property(t => t.ID_SITB_COFINS).HasColumnName("ID_SITB_COFINS");
            //this.Property(t => t.ID_MDPD).HasColumnName("ID_MDPD");
            //this.Property(t => t.ID_MDPD_ST).HasColumnName("ID_MDPD_ST");
            //this.Property(t => t.ID_MDSP).HasColumnName("ID_MDSP");
            //this.Property(t => t.ID_CID_ISSQN_ITPC).HasColumnName("ID_CID_ISSQN_ITPC");
            //this.Property(t => t.ITEM_ITPC).HasColumnName("ITEM_ITPC");
            //this.Property(t => t.TIPO_ITPC).HasColumnName("TIPO_ITPC");
            //this.Property(t => t.COMANDA_ITPC).HasColumnName("COMANDA_ITPC");
            //this.Property(t => t.HORA_ITPC).HasColumnName("HORA_ITPC");
            //this.Property(t => t.QTDE_ITPC).HasColumnName("QTDE_ITPC");
            //this.Property(t => t.FATURADO_ITPC).HasColumnName("FATURADO_ITPC");
            //this.Property(t => t.PRECO_ITPC).HasColumnName("PRECO_ITPC");
            //this.Property(t => t.DESCONTO_ITPC).HasColumnName("DESCONTO_ITPC");
            //this.Property(t => t.FRETE_ITPC).HasColumnName("FRETE_ITPC");
            //this.Property(t => t.SEGURO_ITPC).HasColumnName("SEGURO_ITPC");
            //this.Property(t => t.DESP_ACESSORIA_ITPC).HasColumnName("DESP_ACESSORIA_ITPC");
            //this.Property(t => t.CONDICIONAL_ITPC).HasColumnName("CONDICIONAL_ITPC");
            //this.Property(t => t.PROP_DESCONTO_ITPC).HasColumnName("PROP_DESCONTO_ITPC");
            //this.Property(t => t.PADRAO_DESCONTO_ITPC).HasColumnName("PADRAO_DESCONTO_ITPC");
            //this.Property(t => t.INDTOT_ITPC).HasColumnName("INDTOT_ITPC");
            //this.Property(t => t.BICMS_ITPC).HasColumnName("BICMS_ITPC");
            //this.Property(t => t.PICMS_ITPC).HasColumnName("PICMS_ITPC");
            //this.Property(t => t.ICMS_ITPC).HasColumnName("ICMS_ITPC");
            //this.Property(t => t.RICMS_ITPC).HasColumnName("RICMS_ITPC");
            //this.Property(t => t.BOPICMS_ITPC).HasColumnName("BOPICMS_ITPC");
            //this.Property(t => t.RICMSST_ITPC).HasColumnName("RICMSST_ITPC");
            //this.Property(t => t.MVA_ICMSST_ITPC).HasColumnName("MVA_ICMSST_ITPC");
            //this.Property(t => t.BICMSST_ITPC).HasColumnName("BICMSST_ITPC");
            //this.Property(t => t.PICMSST_ITPC).HasColumnName("PICMSST_ITPC");
            //this.Property(t => t.ICMSST_ITPC).HasColumnName("ICMSST_ITPC");
            //this.Property(t => t.BICMSST_UF_EMIT_ITPC).HasColumnName("BICMSST_UF_EMIT_ITPC");
            //this.Property(t => t.ICMSST_UF_EMIT_ITPC).HasColumnName("ICMSST_UF_EMIT_ITPC");
            //this.Property(t => t.BICMSST_UF_DEST_ITPC).HasColumnName("BICMSST_UF_DEST_ITPC");
            //this.Property(t => t.ICMSST_UF_DEST_ITPC).HasColumnName("ICMSST_UF_DEST_ITPC");
            //this.Property(t => t.BICMSST_ANT_ITPC).HasColumnName("BICMSST_ANT_ITPC");
            //this.Property(t => t.ICMSST_ANT_ITPC).HasColumnName("ICMSST_ANT_ITPC");
            //this.Property(t => t.SELO_IPI_ITPC).HasColumnName("SELO_IPI_ITPC");
            //this.Property(t => t.QSELO_IPI_ITPC).HasColumnName("QSELO_IPI_ITPC");
            //this.Property(t => t.ENQ_IPI_ITPC).HasColumnName("ENQ_IPI_ITPC");
            //this.Property(t => t.CNPJ_PRODUTOR_IPI_ITPC).HasColumnName("CNPJ_PRODUTOR_IPI_ITPC");
            //this.Property(t => t.CALCULO_IPI).HasColumnName("CALCULO_IPI");
            //this.Property(t => t.BIPI_ITPC).HasColumnName("BIPI_ITPC");
            //this.Property(t => t.PIPI_ITPC).HasColumnName("PIPI_ITPC");
            //this.Property(t => t.QIPI_ITPC).HasColumnName("QIPI_ITPC");
            //this.Property(t => t.VIPI_ITPC).HasColumnName("VIPI_ITPC");
            //this.Property(t => t.IPI_ITPC).HasColumnName("IPI_ITPC");
            //this.Property(t => t.CALCULO_PIS).HasColumnName("CALCULO_PIS");
            //this.Property(t => t.BPIS_ITPC).HasColumnName("BPIS_ITPC");
            //this.Property(t => t.PPIS_ITPC).HasColumnName("PPIS_ITPC");
            //this.Property(t => t.QPIS_ITPC).HasColumnName("QPIS_ITPC");
            //this.Property(t => t.PIS_ITPC).HasColumnName("PIS_ITPC");
            //this.Property(t => t.CALCULO_PISST).HasColumnName("CALCULO_PISST");
            //this.Property(t => t.BPISST_ITPC).HasColumnName("BPISST_ITPC");
            //this.Property(t => t.PPISST_ITPC).HasColumnName("PPISST_ITPC");
            //this.Property(t => t.QPISST_ITPC).HasColumnName("QPISST_ITPC");
            //this.Property(t => t.PISST_ITPC).HasColumnName("PISST_ITPC");
            //this.Property(t => t.CALCULO_COFINS).HasColumnName("CALCULO_COFINS");
            //this.Property(t => t.BCOFINS_ITPC).HasColumnName("BCOFINS_ITPC");
            //this.Property(t => t.PCOFINS_ITPC).HasColumnName("PCOFINS_ITPC");
            //this.Property(t => t.QCOFINS_ITPC).HasColumnName("QCOFINS_ITPC");
            //this.Property(t => t.COFINS_ITPC).HasColumnName("COFINS_ITPC");
            //this.Property(t => t.CALCULO_COFINSST).HasColumnName("CALCULO_COFINSST");
            //this.Property(t => t.BCOFINSST_ITPC).HasColumnName("BCOFINSST_ITPC");
            //this.Property(t => t.PCOFINSST_ITPC).HasColumnName("PCOFINSST_ITPC");
            //this.Property(t => t.QCOFINSST_ITPC).HasColumnName("QCOFINSST_ITPC");
            //this.Property(t => t.COFINSST_ITPC).HasColumnName("COFINSST_ITPC");
            //this.Property(t => t.BII_ITPC).HasColumnName("BII_ITPC");
            //this.Property(t => t.ADUII_ITPC).HasColumnName("ADUII_ITPC");
            //this.Property(t => t.IOFII_ITPC).HasColumnName("IOFII_ITPC");
            //this.Property(t => t.II_ITPC).HasColumnName("II_ITPC");
            //this.Property(t => t.OBS_ITPC).HasColumnName("OBS_ITPC");
            //this.Property(t => t.TISSQN_ITPC).HasColumnName("TISSQN_ITPC");
            //this.Property(t => t.BISSQNST_ITPC).HasColumnName("BISSQNST_ITPC");
            //this.Property(t => t.PISSQNST_ITPC).HasColumnName("PISSQNST_ITPC");
            //this.Property(t => t.ISSQN_ITPC).HasColumnName("ISSQN_ITPC");
            //this.Property(t => t.VLRMERC_ITPC).HasColumnName("VLRMERC_ITPC");
            //this.Property(t => t.VLRTOT_ITPC).HasColumnName("VLRTOT_ITPC");
            //this.Property(t => t.QTDE_FATURADA_ITPC).HasColumnName("QTDE_FATURADA_ITPC");
            //this.Property(t => t.QTDE_FATURAR_ITPC).HasColumnName("QTDE_FATURAR_ITPC");

            //// Relationships
            //this.HasOptional(t => t.LOCAIS_ESTOQUE)
            //    .WithMany(t => t.ITEM_PEDIDO_COMPRA)
            //    .HasForeignKey(d => d.LocalEstoqueId);
				
            //this.HasRequired(t => t.PEDIDOS_COMPRA)
            //    .WithMany(t => t.ITEM_PEDIDO_COMPRA)
            //    .HasForeignKey(d => d.ID_PDCP);
				
            //this.HasOptional(t => t.Produto_LISTA)
            //    .WithMany(t => t.ITEM_PEDIDO_COMPRA)
            //    .HasForeignKey(d => d.ID_PDLS);
				
            //this.HasOptional(t => t.VALORES_PRODUTO)
            //    .WithMany(t => t.ITEM_PEDIDO_COMPRA)
            //    .HasForeignKey(d => d.ValorProduto);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.ITEM_PEDIDO_COMPRA)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

