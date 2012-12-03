using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class FuncaoProgramaMap : EntityTypeConfiguration<FuncaoPrograma>
    {
        public FuncaoProgramaMap()
        {
            // Primary Key
            this.HasKey(t => t.FuncaoProgramaId);

            // Properties
            this.Property(t => t.Codigo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Descricao)
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .HasMaxLength(255);

            this.Property(t => t.GeraLogString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.GeraLog);

            // Table & Column Mappings
            this.ToTable("FUNCOES_PROGRAMA");
            this.Property(t => t.FuncaoProgramaId).HasColumnName("ID_FNPR");
            this.Property(t => t.Codigo).HasColumnName("COD_FNPR");
            this.Property(t => t.Descricao).HasColumnName("DESC_FNPR");
            this.Property(t => t.ProgrmaId).HasColumnName("COD_PROG");
            this.Property(t => t.Url).HasColumnName("URL_FNPR");
            this.Property(t => t.Ordem).HasColumnName("ORDEM_FNPR");
            this.Property(t => t.MenuId).HasColumnName("ID_MENU");
            this.Property(t => t.GeraLogString).HasColumnName("GERA_LOG");

            // Relationships
            this.HasOptional(t => t.Menu)
                .WithMany(t => t.FuncoesPrograma)
                .HasForeignKey(d => d.MenuId);

            this.HasOptional(t => t.Programa)
                .WithMany(t => t.Funcoes)
                .HasForeignKey(d => d.ProgrmaId);

        }
    }
}