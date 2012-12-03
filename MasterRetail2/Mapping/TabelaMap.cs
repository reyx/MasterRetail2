using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class TabelaMap : EntityTypeConfiguration<Tabela>
    {
        public TabelaMap()
        {
            // Primary Key
            this.HasKey(t => t.TabelaId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(30);

            this.Property(t => t.Dbf)
                .HasMaxLength(10);

            this.Property(t => t.ClasseVo)
                .HasMaxLength(30);

            this.Property(t => t.Descricao)
                .HasMaxLength(255);

            this.Property(t => t.Chave)
                .HasMaxLength(255);

            this.Property(t => t.TipoChave)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ChaveMr)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TABELAS");
            this.Property(t => t.TabelaId).HasColumnName("ID_TAB");
            this.Property(t => t.Nome).HasColumnName("NOME_TAB");
            this.Property(t => t.Dbf).HasColumnName("DBF_TAB");
            this.Property(t => t.ClasseVo).HasColumnName("CLASSEVO_TAB");
            this.Property(t => t.Descricao).HasColumnName("DESCRICAO_TAB");
            this.Property(t => t.Chave).HasColumnName("CHAVE_TAB");
            this.Property(t => t.TipoChave).HasColumnName("TIPOCHAVE_TAB");
            this.Property(t => t.TamanhoChave).HasColumnName("TAMCHAVE_TAB");
            this.Property(t => t.ChaveMr).HasColumnName("CHAVEMR_TAB");
        }
    }
}