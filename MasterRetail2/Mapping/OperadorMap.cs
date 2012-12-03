using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class OperadorMap : EntityTypeConfiguration<Operador>
    {
        public OperadorMap()
        {
            // Primary Key
            this.HasKey(t => t.OperadorId);

            // Properties
            this.Property(t => t.Codigo)
                .HasMaxLength(18);

            this.Property(t => t.NivelPdv)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NivelRetaguarda)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.NivelLoja)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.SituacaoCartao)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Trilha)
                .HasMaxLength(50);

            this.Property(t => t.Tema)
                .HasMaxLength(30);

            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            // Table & Column Mappings
            this.ToTable("OPERADORES");
            this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
            this.Property(t => t.OperadorId).HasColumnName("COD_OPER");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.CodigoLoja).HasColumnName("CODLJOP_OPER");
            this.Property(t => t.DataCadastro).HasColumnName("DATACAD_OPER");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.NivelPdv).HasColumnName("NIVELPDV_OPER");
            this.Property(t => t.NivelRetaguarda).HasColumnName("NIVELRET_OPER");
            this.Property(t => t.NivelLoja).HasColumnName("NIVELLOJA_OPER");
            this.Property(t => t.PercentualDesconto).HasColumnName("PERDESC_OPER");
            this.Property(t => t.ValorDesconto).HasColumnName("VALDESC_OPER");
            this.Property(t => t.SituacaoCartao).HasColumnName("CARTST_OPER");
            this.Property(t => t.Trilha).HasColumnName("TRILHA_OPER");
            this.Property(t => t.PerfilId).HasColumnName("ID_PERF");
            this.Property(t => t.Tema).HasColumnName("TEMA_OPER");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_OPER");
            this.Property(t => t.MensagemInativo).HasColumnName("MSGINATIVO_OPER");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Operadores)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Perfil)
                .WithMany(t => t.Operadores)
                .HasForeignKey(d => d.PerfilId);

            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Operadores)
                .HasForeignKey(d => d.PessoaId);

        }
    }
}