using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            // Primary Key
            this.HasKey(t => t.ClienteId);

            // Properties
            this.Property(t => t.AtivoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Ativo);

            this.Property(t => t.Interesse)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Captacao)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CLIENTES");
            this.Property(t => t.ClienteId).HasColumnName("COD_CLI");
            this.Property(t => t.TransportadorId).HasColumnName("COD_TRAN");
            this.Property(t => t.VendedorId).HasColumnName("COD_VEND");
            this.Property(t => t.RegiaoId).HasColumnName("COD_REG");
            this.Property(t => t.GrupoClienteId).HasColumnName("COD_GRCL");
            this.Property(t => t.SituacaoId).HasColumnName("COD_SITU");
            this.Property(t => t.IndicacaoId).HasColumnName("COD_IND");
            this.Property(t => t.ListaId).HasColumnName("COD_LISTA");
            this.Property(t => t.PessoaId).HasColumnName("ID_PESSOA");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.ClienteLojaId).HasColumnName("CODCLLJ_CLI");
            this.Property(t => t.AtivoString).HasColumnName("ATIVO_CLI");
            this.Property(t => t.Cadastro).HasColumnName("DATACAD_CLI");
            this.Property(t => t.UltimaVisita).HasColumnName("DATAULTVIS_CLI");
            this.Property(t => t.Interesse).HasColumnName("INTERESSE_CLI");
            this.Property(t => t.Credito).HasColumnName("CREDITO_CLI");
            this.Property(t => t.TaxaEntrega).HasColumnName("TXENTR_CLI");
            this.Property(t => t.LimiteCredito).HasColumnName("LIMITE_CLI");
            this.Property(t => t.Captacao).HasColumnName("CAPTACAO_CLI");

            // Relationships
            this.HasOptional(t => t.GrupoCliente)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.GrupoClienteId);

            this.HasOptional(t => t.Indicacao)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.IndicacaoId);

            this.HasOptional(t => t.Lista)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.ListaId);

            this.HasOptional(t => t.Loja)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.LojaId);

            this.HasOptional(t => t.Pessoa)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.PessoaId);

            this.HasOptional(t => t.Regiao)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.RegiaoId);

            this.HasOptional(t => t.Situacao)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.SituacaoId);

            this.HasOptional(t => t.Transportador)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.TransportadorId);

            this.HasOptional(t => t.Vendedor)
                .WithMany(t => t.Clientes)
                .HasForeignKey(d => d.VendedorId);

        }
    }
}