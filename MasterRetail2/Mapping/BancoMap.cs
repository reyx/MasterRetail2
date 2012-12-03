using Rcky.MasterRetail2.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
	public class BancoMap : EntityTypeConfiguration<Banco>
	{
        public BancoMap()
		{
			// Primary Key
			this.HasKey(t => t.BancoId);

			// Properties
			this.Property(t => t.BancoId)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Nome)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("BANCOS");
			this.Property(t => t.BancoId).HasColumnName("COD_BCO");
			this.Property(t => t.Nome).HasColumnName("NOME_BCO");
		}
	}
}