using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class NotaFiscalMap : EntityTypeConfiguration<NotaFiscal>
	{
        public NotaFiscalMap()
		{
			// Primary Key
			this.HasKey(t => t.NotaFiscalId);

			// Properties
            //this.Property(t => t.CHAVE_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(8);
				
            //this.Property(t => t.DV_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.CHAVENFE_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(44);
				
            //this.Property(t => t.TIPOOP_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.TIPOEMISSAO_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.AMBIENTE_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.VERSAO_NF)
            //    .HasMaxLength(10);
				
            //this.Property(t => t.VERSAOMR_NF)
            //    .HasMaxLength(10);
				
            //this.Property(t => t.CONDICIONAL_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.STATUS_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //this.Property(t => t.MODFRETE_NF)
            //    .IsFixedLength()
            //    .HasMaxLength(1);
				
            //// Table & Column Mappings
            //this.ToTable("NOTAS_FISCAIS");
            //this.Property(t => t.ID_NF).HasColumnName("ID_NF");
            //this.Property(t => t.NUMERO_NF).HasColumnName("NUMERO_NF");
            //this.Property(t => t.CHAVE_NF).HasColumnName("CHAVE_NF");
            //this.Property(t => t.DV_NF).HasColumnName("DV_NF");
            //this.Property(t => t.CHAVENFE_NF).HasColumnName("CHAVENFE_NF");
            //this.Property(t => t.MODELO_NF).HasColumnName("MODELO_NF");
            //this.Property(t => t.TIPOOP_NF).HasColumnName("TIPOOP_NF");
            //this.Property(t => t.TIPOEMISSAO_NF).HasColumnName("TIPOEMISSAO_NF");
            //this.Property(t => t.AMBIENTE_NF).HasColumnName("AMBIENTE_NF");
            //this.Property(t => t.FINALIDADE_NF).HasColumnName("FINALIDADE_NF");
            //this.Property(t => t.TIPODANFE_NF).HasColumnName("TIPODANFE_NF");
            //this.Property(t => t.VERSAO_NF).HasColumnName("VERSAO_NF");
            //this.Property(t => t.VERSAOMR_NF).HasColumnName("VERSAOMR_NF");
            //this.Property(t => t.ID_SRNF).HasColumnName("ID_SRNF");
            //this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            //this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            //this.Property(t => t.FornecedorId).HasColumnName("COD_FORN");
            //this.Property(t => t.CFOP_NTOP).HasColumnName("CFOP_NTOP");
            //this.Property(t => t.CFOP_NTOP_TRAN_NF).HasColumnName("CFOP_NTOP_TRAN_NF");
            //this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            //this.Property(t => t.ID_ENTR).HasColumnName("ID_ENTR");
            //this.Property(t => t.ID_VDA).HasColumnName("ID_VDA");
            //this.Property(t => t.CondicaoPagamentoId).HasColumnName("COD_CDPG");
            //this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            //this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            //this.Property(t => t.ID_VEIC).HasColumnName("ID_VEIC");
            //this.Property(t => t.ID_CID).HasColumnName("ID_CID");
            //this.Property(t => t.DATA_NF).HasColumnName("DATA_NF");
            //this.Property(t => t.EMISSAO_NF).HasColumnName("EMISSAO_NF");
            //this.Property(t => t.SAIENT_NF).HasColumnName("SAIENT_NF");
            //this.Property(t => t.CONDICIONAL_NF).HasColumnName("CONDICIONAL_NF");
            //this.Property(t => t.BICMS_NF).HasColumnName("BICMS_NF");
            //this.Property(t => t.ICMS_NF).HasColumnName("ICMS_NF");
            //this.Property(t => t.BICMSST_NF).HasColumnName("BICMSST_NF");
            //this.Property(t => t.ICMSST_NF).HasColumnName("ICMSST_NF");
            //this.Property(t => t.IPI_NF).HasColumnName("IPI_NF");
            //this.Property(t => t.IPIST_NF).HasColumnName("IPIST_NF");
            //this.Property(t => t.PIS_NF).HasColumnName("PIS_NF");
            //this.Property(t => t.PISST_NF).HasColumnName("PISST_NF");
            //this.Property(t => t.COFINS_NF).HasColumnName("COFINS_NF");
            //this.Property(t => t.COFINSST_NF).HasColumnName("COFINSST_NF");
            //this.Property(t => t.VLRMERC_NF).HasColumnName("VLRMERC_NF");
            //this.Property(t => t.FRETE_NF).HasColumnName("FRETE_NF");
            //this.Property(t => t.SEGURO_NF).HasColumnName("SEGURO_NF");
            //this.Property(t => t.DESCONTO_NF).HasColumnName("DESCONTO_NF");
            //this.Property(t => t.DESP_ACESSORIA_NF).HasColumnName("DESP_ACESSORIA_NF");
            //this.Property(t => t.VLRTOT_NF).HasColumnName("VLRTOT_NF");
            //this.Property(t => t.MENSAGEM_NF).HasColumnName("MENSAGEM_NF");
            //this.Property(t => t.OBS_NF).HasColumnName("OBS_NF");
            //this.Property(t => t.STATUS_NF).HasColumnName("STATUS_NF");
            //this.Property(t => t.ID_ENPS_CLI_NF).HasColumnName("ID_ENPS_CLI_NF");
            //this.Property(t => t.ID_ENPS_ENT_NF).HasColumnName("ID_ENPS_ENT_NF");
            //this.Property(t => t.ID_ENPS_LOJA_NF).HasColumnName("ID_ENPS_LOJA_NF");
            //this.Property(t => t.ID_ENPS_RET_NF).HasColumnName("ID_ENPS_RET_NF");
            //this.Property(t => t.ID_ENPS_TRAN_NF).HasColumnName("ID_ENPS_TRAN_NF");
            //this.Property(t => t.II_NF).HasColumnName("II_NF");
            //this.Property(t => t.BIRRF_NF).HasColumnName("BIRRF_NF");
            //this.Property(t => t.IRRF_NF).HasColumnName("IRRF_NF");
            //this.Property(t => t.BPREV_NF).HasColumnName("BPREV_NF");
            //this.Property(t => t.PREV_NF).HasColumnName("PREV_NF");
            //this.Property(t => t.RIPI_NF).HasColumnName("RIPI_NF");
            //this.Property(t => t.RPIS_NF).HasColumnName("RPIS_NF");
            //this.Property(t => t.RCOFINS_NF).HasColumnName("RCOFINS_NF");
            //this.Property(t => t.RCSLL_NF).HasColumnName("RCSLL_NF");
            //this.Property(t => t.MODFRETE_NF).HasColumnName("MODFRETE_NF");
            //this.Property(t => t.BICMS_TRAN_NF).HasColumnName("BICMS_TRAN_NF");
            //this.Property(t => t.PICMS_TRAN_NF).HasColumnName("PICMS_TRAN_NF");
            //this.Property(t => t.ICMS_TRAN_NF).HasColumnName("ICMS_TRAN_NF");
            //this.Property(t => t.VALOR_TRAN_NF).HasColumnName("VALOR_TRAN_NF");
            //this.Property(t => t.PESOLIQ_NF).HasColumnName("PESOLIQ_NF");
            //this.Property(t => t.PESOBRT_NF).HasColumnName("PESOBRT_NF");
            //this.Property(t => t.PROC_NFE).HasColumnName("PROC_NFE");
            //this.Property(t => t.PROCCANC_NFE).HasColumnName("PROCCANC_NFE");
            //this.Property(t => t.PROCINUT_NFE).HasColumnName("PROCINUT_NFE");

            //// Relationships
            //this.HasOptional(t => t.Cliente)
            //    .WithMany(t => t.NotasFiscais)
            //    .HasForeignKey(d => d.ClienteId);
				
            //this.HasOptional(t => t.CONDICOES_PAGAMENTO)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.CondicaoPagamentoId);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.ID_ENPS_CLI_NF);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA1)
            //    .WithMany(t => t.NOTAS_FISCAIS1)
            //    .HasForeignKey(d => d.ID_ENPS_ENT_NF);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA2)
            //    .WithMany(t => t.NOTAS_FISCAIS2)
            //    .HasForeignKey(d => d.ID_ENPS_LOJA_NF);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA3)
            //    .WithMany(t => t.NOTAS_FISCAIS3)
            //    .HasForeignKey(d => d.ID_ENPS_RET_NF);
				
            //this.HasOptional(t => t.ENDERECOS_PESSOA4)
            //    .WithMany(t => t.NOTAS_FISCAIS4)
            //    .HasForeignKey(d => d.ID_ENPS_TRAN_NF);
				
            //this.HasOptional(t => t.ENTRADA)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.ID_ENTR);
				
            //this.HasOptional(t => t.FORNECEDOR)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.FornecedorId);
				
            //this.HasOptional(t => t.Loja)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.LojaId);
				
            //this.HasOptional(t => t.Operador)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.OperadorId);
				
            //this.HasOptional(t => t.SERIES_NF)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.ID_SRNF);
				
            //this.HasOptional(t => t.TRANSPORTADOR)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.TransportadorId);
				
            //this.HasOptional(t => t.VEICULO)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.ID_VEIC);
				
            //this.HasOptional(t => t.VENDA)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.ID_VDA);
				
            //this.HasOptional(t => t.VENDEDOR)
            //    .WithMany(t => t.NOTAS_FISCAIS)
            //    .HasForeignKey(d => d.VendedorId);
				
		}
	}
}

