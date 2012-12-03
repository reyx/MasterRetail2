using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class NcmMap : EntityTypeConfiguration<Ncm>
    {
        public NcmMap()
        {
            // Primary Key
            this.HasKey(t => t.NcmId);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(8);

            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            this.Property(t => t.Capitulo)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Posicao)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Subposicao)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Item)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Subitem)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("NCM");
            this.Property(t => t.NcmId).HasColumnName("ID_NCM");
            this.Property(t => t.Codigo).HasColumnName("COD_NCM");
            this.Property(t => t.Descricao).HasColumnName("DESC_NCM");
            this.Property(t => t.Capitulo).HasColumnName("CAP_NCM");
            this.Property(t => t.Posicao).HasColumnName("POS_NCM");
            this.Property(t => t.Subposicao).HasColumnName("SPOS_NCM");
            this.Property(t => t.Item).HasColumnName("ITEM_NCM");
            this.Property(t => t.Subitem).HasColumnName("SUBITEM_NCM");
            this.Property(t => t.Aliquota).HasColumnName("ALIQ_NCM");
        }
    }
}