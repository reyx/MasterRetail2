using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class EnderecoPessoaMap : EntityTypeConfiguration<EnderecoPessoa>
    {
        public EnderecoPessoaMap()
        {
            // Primary Key
            this.HasKey(t => t.EnderecoPessoaId);

            // Properties
            this.Property(t => t.Logradouro)
                .HasMaxLength(200);

            this.Property(t => t.Numero)
                .HasMaxLength(8);

            this.Property(t => t.Complemento)
                .HasMaxLength(26);

            this.Property(t => t.Bairro)
                .HasMaxLength(100);

            this.Property(t => t.Cidade)
                .HasMaxLength(100);

            this.Property(t => t.Uf)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Cep)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.PadraoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Padrao);

            // Table & Column Mappings
            this.ToTable("ENDERECOS_PESSOA");
            this.Property(t => t.EnderecoPessoaId).HasColumnName("ID_ENPS");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.TipoEnderecoId).HasColumnName("ID_TPEN");
            this.Property(t => t.Logradouro).HasColumnName("LOGRADOURO_ENPS");
            this.Property(t => t.Numero).HasColumnName("NUMERO_ENPS");
            this.Property(t => t.Complemento).HasColumnName("COMPL_ENPS");
            this.Property(t => t.Bairro).HasColumnName("BAIRRO_ENPS");
            this.Property(t => t.Cidade).HasColumnName("CIDADE_ENPS");
            this.Property(t => t.CodigoIbgeCidade).HasColumnName("CODIBGE_CID_ENPS");
            this.Property(t => t.Uf).HasColumnName("UF_ENPS");
            this.Property(t => t.CodigoIbgeUf).HasColumnName("CODIBGE_UF_ENPS");
            this.Property(t => t.Cep).HasColumnName("CEP_ENPS");
            this.Property(t => t.PadraoString).HasColumnName("PADRAO_ENPS");

            // Relationships
            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.EnderecosPessoa)
                .HasForeignKey(d => d.PessoaId);

            this.HasOptional(t => t.TipoEndereco)
                .WithMany(t => t.EnderecosPessoa)
                .HasForeignKey(d => d.TipoEnderecoId);

        }
    }
}