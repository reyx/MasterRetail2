using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class MicroTerminalMap : EntityTypeConfiguration<MicroTerminal>
    {
        public MicroTerminalMap()
        {
            // Primary Key
            this.HasKey(t => t.MicroTerminalId);

            // Properties
            this.Property(t => t.DESC_MTER)
                .HasMaxLength(20);

            this.Property(t => t.TIPO_MTER)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NOVACOM_MTER)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TIPOCON_MTER)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.BALCNF_MTER)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.TORRE_MTER)
                .HasMaxLength(10);

            this.Property(t => t.ENDIP_MTER)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("MICRO_TERMINAIS");
            this.Property(t => t.MicroTerminalId).HasColumnName("ID_MTER");
            this.Property(t => t.NUMERO_MTER).HasColumnName("NUMERO_MTER");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.PdvId).HasColumnName("ID_PDV");
            this.Property(t => t.DESC_MTER).HasColumnName("DESC_MTER");
            this.Property(t => t.TIPO_MTER).HasColumnName("TIPO_MTER");
            this.Property(t => t.TIMEOUT_MTER).HasColumnName("TIMEOUT_MTER");
            this.Property(t => t.NOVACOM_MTER).HasColumnName("NOVACOM_MTER");
            this.Property(t => t.TIPOCON_MTER).HasColumnName("TIPOCON_MTER");
            this.Property(t => t.TECLACOM_MTER).HasColumnName("TECLACOM_MTER");
            this.Property(t => t.TECLACLI_MTER).HasColumnName("TECLACLI_MTER");
            this.Property(t => t.TECLAVEND_MTER).HasColumnName("TECLAVEND_MTER");
            this.Property(t => t.TECLABAL_MTER).HasColumnName("TECLABAL_MTER");
            this.Property(t => t.TECLAPROD_MTER).HasColumnName("TECLAPROD_MTER");
            this.Property(t => t.TECLAMULT_MTER).HasColumnName("TECLAMULT_MTER");
            this.Property(t => t.TECLAPRECO_MTER).HasColumnName("TECLAPRECO_MTER");
            this.Property(t => t.TECLAFEC_MTER).HasColumnName("TECLAFEC_MTER");
            this.Property(t => t.TECLAFCP_MTER).HasColumnName("TECLAFCP_MTER");
            this.Property(t => t.TECLACNS_MTER).HasColumnName("TECLACNS_MTER");
            this.Property(t => t.TECLASIM_MTER).HasColumnName("TECLASIM_MTER");
            this.Property(t => t.TECLANAO_MTER).HasColumnName("TECLANAO_MTER");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.COMINI_MTER).HasColumnName("COMINI_MTER");
            this.Property(t => t.COMFIN_MTER).HasColumnName("COMFIN_MTER");
            this.Property(t => t.TOSERIAL_MTER).HasColumnName("TOSERIAL_MTER");
            this.Property(t => t.BALTMRET_MTER).HasColumnName("BALTMRET_MTER");
            this.Property(t => t.BALINI_MTER).HasColumnName("BALINI_MTER");
            this.Property(t => t.BALTAM_MTER).HasColumnName("BALTAM_MTER");
            this.Property(t => t.BALDIV_MTER).HasColumnName("BALDIV_MTER");
            this.Property(t => t.BALCNF_MTER).HasColumnName("BALCNF_MTER");
            this.Property(t => t.TORRE_MTER).HasColumnName("TORRE_MTER");
            this.Property(t => t.ENDIP_MTER).HasColumnName("ENDIP_MTER");

            // Relationships
            this.HasOptional(t => t.Lista)
                .WithMany(t => t.MicroTerminais)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.MicroTerminais)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Pdv)
                .WithMany(t => t.MicroTerminais)
                .HasForeignKey(d => d.PdvId);

        }
    }
}