using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.PessoaId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(60);

            this.Property(t => t.Tipo)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Fantasia)
                .HasMaxLength(50);

            this.Property(t => t.Aniversario)
                .HasMaxLength(4);

            this.Property(t => t.Natureza)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Senha)
                .HasMaxLength(32);

            this.Property(t => t.SenhaPdv)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("PESSOAS");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Nome).HasColumnName("NOME_PESSOA");
            this.Property(t => t.Tipo).HasColumnName("TIPO_PESSOA");
            this.Property(t => t.Observacao).HasColumnName("OBS_PESSOA");
            this.Property(t => t.Fantasia).HasColumnName("FANTASIA_PESSOA");
            this.Property(t => t.DocumentoId).HasColumnName("COD_DOC");
            this.Property(t => t.Nascimento).HasColumnName("NASCIMENTO_PESSOA");
            this.Property(t => t.Aniversario).HasColumnName("ANIVERSARIO_PESSOA");
            this.Property(t => t.Cadastro).HasColumnName("DATACAD_PESSOA");
            this.Property(t => t.Natureza).HasColumnName("NATUREZA_PESSOA");
            this.Property(t => t.Senha).HasColumnName("SENHA_PESSOA");
            this.Property(t => t.Foto).HasColumnName("FOTO_PESSOA");
            this.Property(t => t.Senha).HasColumnName("SENHA_PDV");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Pessoas)
                .HasForeignKey(d => d.LojaId);

        }
    }
}