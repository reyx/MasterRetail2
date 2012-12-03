using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class OperadorValorGrupoMap : EntityTypeConfiguration<OperadorValorGrupo>
    {
        public OperadorValorGrupoMap()
        {
            // Primary Key
            this.HasKey(t => t.OperadorValorGrupoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("OPERADORES_VALOR_GRUPO");
            this.Property(t => t.OperadorValorGrupoId).HasColumnName("ID_OPVG");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.ValorGrupoId).HasColumnName("ID_VLGR");

            // Relationships
            this.HasOptional(t => t.Operador)
                .WithMany(t => t.ValoresGrupo)
                .HasForeignKey(d => d.OperadorId);

            this.HasOptional(t => t.ValorGrupo)
                .WithMany(t => t.Operadores)
                .HasForeignKey(d => d.ValorGrupoId);

        }
    }
}