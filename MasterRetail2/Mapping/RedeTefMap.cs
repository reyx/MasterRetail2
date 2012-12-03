using Rcky.MasterRetail2.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Rcky.MasterRetail2.Mapping
{
    public class RedeTefMap : EntityTypeConfiguration<RedeTef>
    {
        public RedeTefMap()
        {
            // Primary Key
            this.HasKey(t => t.RedeTefId);

            // Properties
            this.Property(t => t.Nome)
                .HasMaxLength(30);

            this.Property(t => t.ArquivoTmp)
                .HasMaxLength(400);

            this.Property(t => t.ArquivoReq)
                .HasMaxLength(400);

            this.Property(t => t.ArquivoSta)
                .HasMaxLength(400);

            this.Property(t => t.ArquivoRes)
                .HasMaxLength(400);

            this.Property(t => t.ArquivoExe)
                .HasMaxLength(400);

            this.Property(t => t.TipoCnf)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.MascVal)
                .HasMaxLength(20);

            this.Property(t => t.AutoFinal)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.AutoCanc)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Atv)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("REDES_TEF");
            this.Property(t => t.RedeTefId).HasColumnName("ID_RDTF");
            this.Property(t => t.LojaId).HasColumnName("COD_LOJA");
            this.Property(t => t.Numero).HasColumnName("NUMERO_RDTF");
            this.Property(t => t.Nome).HasColumnName("NOME_RDTF");
            this.Property(t => t.ArquivoTmp).HasColumnName("ARQTMP_RDTF");
            this.Property(t => t.ArquivoReq).HasColumnName("ARQREQ_RDTF");
            this.Property(t => t.ArquivoSta).HasColumnName("ARQSTA_RDTF");
            this.Property(t => t.ArquivoRes).HasColumnName("ARQRES_RDTF");
            this.Property(t => t.ArquivoExe).HasColumnName("ARQEXE_RDTF");
            this.Property(t => t.Tentativas).HasColumnName("TENTATIVAS_RDTF");
            this.Property(t => t.ToTef).HasColumnName("TOTEF_RDTF");
            this.Property(t => t.ToTrs).HasColumnName("TOTRS_RDTF");
            this.Property(t => t.ViasTef).HasColumnName("VIASTEF_RDTF");
            this.Property(t => t.ViasAdm).HasColumnName("VIASADM_RDTF");
            this.Property(t => t.TipoCnf).HasColumnName("TIPOCNF_RDTF");
            this.Property(t => t.Mtpl).HasColumnName("MTPL_RDTF");
            this.Property(t => t.MtplEnv).HasColumnName("MTPLENV_RDTF");
            this.Property(t => t.MascVal).HasColumnName("MASCVAL_RDTF");
            this.Property(t => t.MensagemInat).HasColumnName("MENSINAT_RDTF");
            this.Property(t => t.MensagemNcn).HasColumnName("MENSNCN_RDTF");
            this.Property(t => t.MensagemCnc).HasColumnName("MENSCNC_RDTF");
            this.Property(t => t.MensagemNc2).HasColumnName("MENSNC2_RDTF");
            this.Property(t => t.AutoFinal).HasColumnName("AUTOFINAL_RDTF");
            this.Property(t => t.AutoCanc).HasColumnName("AUTOCANC_RDTF");
            this.Property(t => t.Atv).HasColumnName("ATV_RDTF");

            // Relationships
            this.HasOptional(t => t.Loja)
                .WithMany(t => t.RedesTef)
                .HasForeignKey(d => d.LojaId);

        }
    }
}