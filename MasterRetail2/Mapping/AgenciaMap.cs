using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class AgenciaMap : EntityTypeConfiguration<Agencia>
	{
        public AgenciaMap()
		{
			// Primary Key
			this.HasKey(t => t.AgenciaId);

			// Properties
			this.Property(t => t.Digito)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.Nome)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("AGENCIAS");
			this.Property(t => t.AgenciaId).HasColumnName("ID_AGEN");
			this.Property(t => t.Numero).HasColumnName("NUMERO_AGEN");
			this.Property(t => t.Digito).HasColumnName("DIGITO_AGEN");
			this.Property(t => t.Nome).HasColumnName("NOME_AGEN");
			this.Property(t => t.Observacao).HasColumnName("OBS_AGEN");
			this.Property(t => t.BancoId).HasColumnName("COD_BCO");

			// Relationships
			this.HasOptional(t => t.Banco)
				.WithMany(t => t.Agencias)
				.HasForeignKey(d => d.BancoId);
				
		}
	}
}