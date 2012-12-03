using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class LogAcessoMap : EntityTypeConfiguration<LogAcesso>
	{
        public LogAcessoMap()
		{
			// Primary Key
			this.HasKey(t => t.LogAcessoId);

			// Properties
			this.Property(t => t.Ip)
				.HasMaxLength(15);
				
			this.Property(t => t.Acao)
				.HasMaxLength(4000);
				
			// Table & Column Mappings
			this.ToTable("LOGS_ACESSO");
			this.Property(t => t.LogAcessoId).HasColumnName("ID_LOG");
			this.Property(t => t.OperadorId).HasColumnName("ID_OPER");
			this.Property(t => t.Ip).HasColumnName("IP_LOG");
			this.Property(t => t.Data).HasColumnName("DATA_LOG");
			this.Property(t => t.Acao).HasColumnName("ACAO_LOG");

			// Relationships
			this.HasOptional(t => t.Operador)
				.WithMany(t => t.LogsAcesso)
				.HasForeignKey(d => d.OperadorId);
				
		}
	}
}