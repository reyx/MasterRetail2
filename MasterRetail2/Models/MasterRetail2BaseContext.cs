using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Rcky.MasterRetail2.Entities;
using Rcky.MasterRetail2.Mapping;

namespace Rcky.MasterRetail2.Models
{
	public class MasterRetail2BaseContext : DbContext
	{
        public MasterRetail2BaseContext()
            : base("Name=MasterRetail2Base")
        {

        }

        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cnae> Cnaes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FuncaoPrograma> FuncoesProgramas { get; set; }
        public DbSet<GrupoMenu> GruposMenus { get; set; }
        public DbSet<ImagemItemManual> ImagensItensManuais { get; set; }
        public DbSet<ItemManual> ItensManuais { get; set; }
        public DbSet<Logradouro> Logradouros { get; set; }
        public DbSet<Manual> Manuais { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<ModalidadeProduto> ModalidadesProdutos { get; set; }
        public DbSet<MotivoDesoneracaoProduto> MotivosDesoneracaoProdutos { get; set; }
        public DbSet<NaturezaOperacao> NaturezasOperacao { get; set; }
        public DbSet<Ncm> Ncms { get; set; }
        public DbSet<NcmCnae> NcmsCnaes { get; set; }
        public DbSet<NcmUfRegimeTributario> NcmsUfRegimesTributarios { get; set; }
        public DbSet<OrigemProduto> OrigensProdutos { get; set; }
        public DbSet<Programa> Programas { get; set; }
        public DbSet<RegimeTributario> RegimesTributarios { get; set; }
        public DbSet<SituacaoTributaria> SituacoesTributarias { get; set; }
        public DbSet<Submenu> Submenus { get; set; }
        public DbSet<Tabela> Tabelas { get; set; }
        public DbSet<TipoParametro> TiposParametros { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<UfWebservice> UfsWebservices { get; set; }
        public DbSet<Webservice> Webservices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
			modelBuilder.Configurations.Add(new BairroMap());
			modelBuilder.Configurations.Add(new CidadeMap());
			modelBuilder.Configurations.Add(new CnaeMap());
			modelBuilder.Configurations.Add(new DocumentoMap());
			modelBuilder.Configurations.Add(new EnderecoMap());
			modelBuilder.Configurations.Add(new FuncaoProgramaMap());
			modelBuilder.Configurations.Add(new GrupoMenuMap());
			modelBuilder.Configurations.Add(new ImagemItemManualMap());
			modelBuilder.Configurations.Add(new ItemManualMap());
			modelBuilder.Configurations.Add(new LogradouroMap());
			modelBuilder.Configurations.Add(new ManualMap());
			modelBuilder.Configurations.Add(new MenuMap());
			modelBuilder.Configurations.Add(new ModalideProdutoMap());
			modelBuilder.Configurations.Add(new MotivoDesoneracaoProdutoMap());
			modelBuilder.Configurations.Add(new NaturezaOperacaoMap());
			modelBuilder.Configurations.Add(new NcmMap());
			modelBuilder.Configurations.Add(new NcmCnaeMap());
			modelBuilder.Configurations.Add(new NcmUfRegimeTributarioMap());
			modelBuilder.Configurations.Add(new OrigemProdutoMap());
			modelBuilder.Configurations.Add(new ProgramaMap());
			modelBuilder.Configurations.Add(new RegimeTributarioMap());
			modelBuilder.Configurations.Add(new SituacaoTributariaMap());
			modelBuilder.Configurations.Add(new SubmenuMap());
			modelBuilder.Configurations.Add(new TabelaMap());
			modelBuilder.Configurations.Add(new TipoParametroMap());
			modelBuilder.Configurations.Add(new UfMap());
			modelBuilder.Configurations.Add(new UfWebserviceMap());
			modelBuilder.Configurations.Add(new WebserviceMap());
		}
	}
}

