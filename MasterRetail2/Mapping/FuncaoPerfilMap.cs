using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Rcky.MasterRetail2.Models;

namespace Rcky.MasterRetail2.Mapping
{
    public class FuncaoPerfilMap : EntityTypeConfiguration<FuncaoPerfil>
    {
        public FuncaoPerfilMap()
        {
            // Primary Key
            this.HasKey(t => t.FuncaoPerfilId);

            // Properties
            this.Property(t => t.PermitidoString)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Ignore(t => t.Permitido);

            // Table & Column Mappings
            this.ToTable("FUNCOES_PERFIL");
            this.Property(t => t.FuncaoPerfilId).HasColumnName("ID_FNPF");
            this.Property(t => t.PerfilId).HasColumnName("ID_PERF");
            this.Property(t => t.FuncaoProgramaId).HasColumnName("ID_FNPR");
            this.Property(t => t.PermitidoString).HasColumnName("PERMITIDO_FNPF");

            // Relationships
            this.HasOptional(t => t.Perfil)
                .WithMany(t => t.Funcoes)
                .HasForeignKey(d => d.PerfilId);

        }
    }
}