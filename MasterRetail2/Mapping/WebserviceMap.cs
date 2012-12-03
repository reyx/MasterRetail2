using Rcky.MasterRetail2.Models;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class WebserviceMap : EntityTypeConfiguration<Webservice>
    {
        public WebserviceMap()
        {
            // Primary Key
            this.HasKey(t => t.WebserviceId);

            // Properties
            this.Property(t => t.Servico)
                .HasMaxLength(50);

            this.Property(t => t.Url)
                .HasMaxLength(155);

            this.Property(t => t.Versao)
                .HasMaxLength(10);

            this.Property(t => t.Ambiente)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("WEBSERVICES");
            this.Property(t => t.WebserviceId).HasColumnName("ID_WSVC");
            this.Property(t => t.Servico).HasColumnName("SERVICO_WSVC");
            this.Property(t => t.Url).HasColumnName("URL_WSVC");
            this.Property(t => t.Versao).HasColumnName("VERSAO_WSVC");
            this.Property(t => t.Ambiente).HasColumnName("AMBIENTE_WSVC");
        }
    }
}