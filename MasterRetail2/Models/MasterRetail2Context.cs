using Rcky.MasterRetail2.Entities;
using Rcky.MasterRetail2.Mapping;
//using Rcky.MasterRetail2.Mapping;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MasterRetail2.Models
{
    public class MasterRetail2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the ApplicationStart method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<MasterRetail2.Models.MasterRetail2Context>());

        public MasterRetail2Context()
            : base("Name=MasterRetail2")
        {

        }

        public DbSet<Acessorio> Acessorios { get; set; }
        public DbSet<Adicao> Adicoes { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<ArquivoRecebido> ArquivoRecebidos { get; set; }
        public DbSet<Arvore> Arvores { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Bandeira> Bandeiras { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CnaeLoja> CnaeLojas { get; set; }
        public DbSet<CodigoBarras> CodigoBarrass { get; set; }
        public DbSet<CodigoTributacao> CodigoTributacoes { get; set; }
        public DbSet<CodigoTributacaoEcf> CodigosTributacaoEcf { get; set; }
        public DbSet<Comissao> Comissoes { get; set; }
        public DbSet<CondicaoPagamento> CondicoesPagamentos { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<ConsultorLoja> ConsultoresLojas { get; set; }
        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<ContaCorrenteLoja> ContasCorrentesLojas { get; set; }
        public DbSet<ContaPagar> ContasPagar { get; set; }
        public DbSet<ContaReceber> ContaReceber { get; set; }
        public DbSet<ContatoCliente> ContatosCliente { get; set; }
        public DbSet<CupomFiscal> CuponsFiscals { get; set; }
        public DbSet<CupomFiscalNf> CuponsFiscalNfs { get; set; }
        public DbSet<DeclaracaoImportacao> DeclaracoesImportacao { get; set; }
        public DbSet<DespesaBase> DespesasBase { get; set; }
        public DbSet<DiaCondicaoPagamento> DiasCondicoesPagamento { get; set; }
        public DbSet<DocumentoPessoa> DocumentosPessoas { get; set; }
        public DbSet<Ecf> Ecfs { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<EnderecoPessoa> EnderecosPessoas { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Entregador> Entregadores { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<EquipamentoProduto> EquipamentosProdutos { get; set; }
        public DbSet<EstoqueProduto> EstoquesProdutos { get; set; }
        public DbSet<EstoqueProdutoCubo> EstoquesProdutosCubos { get; set; }
        public DbSet<EvolucaoCusto> EvolucoesCusto { get; set; }
        public DbSet<FoneDialUp> FonesDialUp { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<FornecedorProduto> FornecedoresProdutos { get; set; }
        public DbSet<FotoProduto> FotosProdutos { get; set; }
        public DbSet<FuncaoOperador> FuncoesOperadores { get; set; }
        public DbSet<FuncaoPerfil> FuncoesPerfis { get; set; }
        public DbSet<GrauRelacionamento> GrausRelacionamentos { get; set; }
        public DbSet<GrupoCliente> GruposClientes { get; set; }
        public DbSet<GrupoDespesa> GruposDespesas { get; set; }
        public DbSet<GrupoFaturamento> GruposFaturamentos { get; set; }
        public DbSet<GrupoTributacaoProduto> GruposTributacaoProdutos { get; set; }
        public DbSet<GrupoPdv> GruposPdvs { get; set; }
        public DbSet<GrupoProduto> GruposProdutos { get; set; }
        public DbSet<HistoricoLancamento> HistoricosLancamentos { get; set; }
        public DbSet<HistoricoEquipamento> HistoricosEquipamentos { get; set; }
        public DbSet<Indicacao> Indicacoes { get; set; }
        public DbSet<InstrucaoPdv> InstrucoesPdvs { get; set; }
        public DbSet<InutilizacaoNfe> InutilizacoesNfes { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<ItemArvore> ItensArvores { get; set; }
        public DbSet<ItemEntrada> ItensEntradas { get; set; }
        public DbSet<ItemInventario> ItensInventarios { get; set; }
        public DbSet<ItemKit> ItensKits { get; set; }
        public DbSet<ItemMovimento> ItensMovimentos { get; set; }
        public DbSet<ItemNotaFiscal> ItensNotasFiscais { get; set; }
        public DbSet<ItemPedidoCompra> ItensPedidosCompras { get; set; }
        public DbSet<ItemPedidoVenda> ItensPedidosVendas { get; set; }
        public DbSet<ItemPromocao> ItensPromocoes { get; set; }
        public DbSet<ItemTecladoRapido> ItensTeclados { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }
        public DbSet<Kit> Kits { get; set; }
        public DbSet<Lacre> Lacres { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<LayoutBoleto> LayoutBoletos { get; set; }
        public DbSet<LayoutCnab> LayoutCnabs { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Lista> Listas { get; set; }
        public DbSet<ListaLoja> ListasLojas { get; set; }
        public DbSet<LocalEstoque> LocaisEstoques { get; set; }
        public DbSet<LogAcesso> LogAcessos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<LojaCliente> LojasClientes { get; set; }
        public DbSet<LojaOperador> LojasOperadores { get; set; }
        public DbSet<MapaResumo> MapasResumo { get; set; }
        public DbSet<MarcaEcf> MarcaEcfs { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<MicroTerminal> MicroTerminais { get; set; }
        public DbSet<ModeloEcf> ModelosEcfs { get; set; }
        public DbSet<MovimentacaoEquipamento> MovimentacoesEquipamentos { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<MovimentoPdv> MovimentosPdvs { get; set; }
        public DbSet<NotaFiscal> NotasFiscals { get; set; }
        public DbSet<Noticia> Noticias { get; set; }
        public DbSet<NumeroMapaResumo> NumerosMapasResumo { get; set; }
        public DbSet<OcorrenciaPdv> OcorrenciasPdvs { get; set; }
        public DbSet<Operador> Operadores { get; set; }
        public DbSet<OperadorValorGrupo> OperadoresValoresGrupos { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<ParametroPdv> ParametrosPdvs { get; set; }
        public DbSet<ParcelamentoSubtipoRecebimento> ParcelamentosSubtipoRecebimentos { get; set; }
        public DbSet<Pdv> Pdvs { get; set; }
        public DbSet<PedidoCompra> PedidosCompras { get; set; }
        public DbSet<PedidoTransito> PedidosTransito { get; set; }
        public DbSet<PedidoVenda> PedidosVendas { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaRelacionamento> PessoasRelacionamentos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoLista> ProdutosListas { get; set; }
        public DbSet<ProdutoLoja> ProdutosLojas { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Propriedade> Propriedades { get; set; }
        public DbSet<PropriedadeProduto> PropriedadesProdutos { get; set; }
        public DbSet<RecebimentoPdv> RecebimentosPdvs { get; set; }
        public DbSet<RecebimentoVenda> RecebimentosVendas { get; set; }
        public DbSet<RedeTef> RedesTef { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<SerieNf> SeriesNf { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<SetorBalanca> SetoresBalanca { get; set; }
        public DbSet<Situacao> Situacoes { get; set; }
        public DbSet<SubtipoRecebimento> SubtipoRecebimentos { get; set; }
        public DbSet<TecladoRapido> TecladosRapidos { get; set; }
        public DbSet<TecladoRapidoPdv> TecladosRapidosPdvs { get; set; }
        public DbSet<TeclaMicroTerminal> TeclasMicroTerminais { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoCobranca> TiposCobrancas { get; set; }
        public DbSet<TipoDespesa> TiposDespesas { get; set; }
        public DbSet<TipoEndereco> TiposEnderecos { get; set; }
        public DbSet<TipoEquipamento> TiposEquipamentos { get; set; }
        public DbSet<TipoGrupo> TiposGrupos { get; set; }
        public DbSet<TipoMovimento> TiposMovimentos { get; set; }
        public DbSet<TipoOcorrencia> TiposOcorrencias { get; set; }
        public DbSet<TipoParametroPdv> TiposParametrosPdvs { get; set; }
        public DbSet<TipoRecebimento> TiposRecebimentos { get; set; }
        public DbSet<TipoSangria> TiposSangrias { get; set; }
        public DbSet<TransacaoEstoque> TransacoesEstoques { get; set; }
        public DbSet<Transportador> Transportadores { get; set; }
        public DbSet<Tributacao> Tributacoes { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<ValorGrupo> ValoresGrupos { get; set; }
        public DbSet<ValorGrupoLoja> ValoresGruposLojas { get; set; }
        public DbSet<ValorMapaResumo> ValoresMapasResumo { get; set; }
        public DbSet<ValorProduto> ValoesrProdutos { get; set; }
        public DbSet<ValorPropriedade> ValoresPropriedades { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaCubo> VendasCubos { get; set; }
        public DbSet<VendaProdutoCubo> VendasProdutosCubos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Volume> Volumes { get; set; }
        public DbSet<VolumeEntrada> VolumesEntradas { get; set; }
        public DbSet<VolumeVenda> VolumesVendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Configurations.Add(new AcessorioMap());
            modelBuilder.Configurations.Add(new AdicaoMap());
            modelBuilder.Configurations.Add(new AgenciaMap());
            modelBuilder.Configurations.Add(new ArquivoRecebidoMap());
            modelBuilder.Configurations.Add(new ArvoreMap());
            modelBuilder.Configurations.Add(new BancoMap());
            modelBuilder.Configurations.Add(new BandeiraMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new CnaeLojaMap());
            modelBuilder.Configurations.Add(new CodigoBarrasMap());
            modelBuilder.Configurations.Add(new CodigoTributacaoMap());
            modelBuilder.Configurations.Add(new CodigoTributacaoEcfMap());
            modelBuilder.Configurations.Add(new ComissaoMap());
            modelBuilder.Configurations.Add(new CondicaoPagamentoMap());
            modelBuilder.Configurations.Add(new ConsultorMap());
            modelBuilder.Configurations.Add(new ConsultorLojaMap());
            modelBuilder.Configurations.Add(new ContaCorrenteMap());
            modelBuilder.Configurations.Add(new ContaCorrenteLojaMap());
            modelBuilder.Configurations.Add(new ContaPagarMap());
            modelBuilder.Configurations.Add(new ContaReceberMap());
            modelBuilder.Configurations.Add(new ContatoClienteMap());
            modelBuilder.Configurations.Add(new CupomFiscalMap());
            modelBuilder.Configurations.Add(new CupomFiscalNfMap());
            modelBuilder.Configurations.Add(new DeclaracaoImportacaoMap());
            modelBuilder.Configurations.Add(new DespesaBaseMap());
            modelBuilder.Configurations.Add(new DiaCondicaoPagamentoMap());
            modelBuilder.Configurations.Add(new DocumentoPessoaMap());
            modelBuilder.Configurations.Add(new EcfMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new EnderecoPessoaMap());
            modelBuilder.Configurations.Add(new EntradaMap());
            modelBuilder.Configurations.Add(new EntregadorMap());
            modelBuilder.Configurations.Add(new EquipamentoMap());
            modelBuilder.Configurations.Add(new EquipamentoProdutoMap());
            modelBuilder.Configurations.Add(new EstoqueProdutoMap());
            modelBuilder.Configurations.Add(new EstoqueProdutoCuboMap());
            modelBuilder.Configurations.Add(new EvolucaoCustoMap());
            modelBuilder.Configurations.Add(new FoneMap());
            modelBuilder.Configurations.Add(new FoneDialUpMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
            modelBuilder.Configurations.Add(new FornecedorProdutoMap());
            modelBuilder.Configurations.Add(new FotoProdutoMap());
            modelBuilder.Configurations.Add(new FuncaoOperadorMap());
            modelBuilder.Configurations.Add(new FuncaoPerfilMap());
            modelBuilder.Configurations.Add(new GrauRelacionamentoMap());
            modelBuilder.Configurations.Add(new GrupoClienteMap());
            modelBuilder.Configurations.Add(new GrupoDespesaMap());
            modelBuilder.Configurations.Add(new GrupoFaturamentoMap());
            modelBuilder.Configurations.Add(new GrupoTributacaoMap());
            modelBuilder.Configurations.Add(new GrupoPdvMap());
            modelBuilder.Configurations.Add(new GrupoProdutoMap());
            modelBuilder.Configurations.Add(new HistoricoLancamentoMap());
            modelBuilder.Configurations.Add(new HistoricoEquipamentoMap());
            modelBuilder.Configurations.Add(new IndicacaoMap());
            modelBuilder.Configurations.Add(new InstrucaoPdvMap());
            modelBuilder.Configurations.Add(new InutilizacaoNfeMap());
            modelBuilder.Configurations.Add(new InventarioMap());
            modelBuilder.Configurations.Add(new ItemArvoreMap());
            modelBuilder.Configurations.Add(new ItemEntradaMap());
            modelBuilder.Configurations.Add(new ItemInventarioMap());
            modelBuilder.Configurations.Add(new ItemKitMap());
            modelBuilder.Configurations.Add(new ItemMovimentoMap());
            modelBuilder.Configurations.Add(new ItemNotaFiscalMap());
            modelBuilder.Configurations.Add(new ItemPedidoCompraMap());
            modelBuilder.Configurations.Add(new ItemPedidoVendaMap());
            modelBuilder.Configurations.Add(new ItemPromocaoMap());
            modelBuilder.Configurations.Add(new ItemTecladoRapidoMap());
            modelBuilder.Configurations.Add(new ItemVendaMap());
            modelBuilder.Configurations.Add(new KitMap());
            modelBuilder.Configurations.Add(new LacreMap());
            modelBuilder.Configurations.Add(new LancamentoMap());
            modelBuilder.Configurations.Add(new LayoutBoletoMap());
            modelBuilder.Configurations.Add(new LayoutCnabMap());
            modelBuilder.Configurations.Add(new LinkMap());
            modelBuilder.Configurations.Add(new ListaMap());
            modelBuilder.Configurations.Add(new ListaLojaMap());
            modelBuilder.Configurations.Add(new LocalEstoqueMap());
            modelBuilder.Configurations.Add(new LogAcessoMap());
            modelBuilder.Configurations.Add(new LojaMap());
            modelBuilder.Configurations.Add(new LojaClienteMap());
            modelBuilder.Configurations.Add(new LojaOperadorMap());
            modelBuilder.Configurations.Add(new MapaResumoMap());
            modelBuilder.Configurations.Add(new MarcaEcfMap());
            modelBuilder.Configurations.Add(new MensagemMap());
            modelBuilder.Configurations.Add(new MicroTerminalMap());
            modelBuilder.Configurations.Add(new ModeloEcfMap());
            modelBuilder.Configurations.Add(new MovimentacaoEquipamentoMap());
            modelBuilder.Configurations.Add(new MovimentoMap());
            modelBuilder.Configurations.Add(new MovimentoPdvMap());
            modelBuilder.Configurations.Add(new NotaFiscalMap());
            modelBuilder.Configurations.Add(new NoticiaMap());
            modelBuilder.Configurations.Add(new NumeroMapaResumoMap());
            modelBuilder.Configurations.Add(new OcorrenciaPdvMap());
            modelBuilder.Configurations.Add(new OperadorMap());
            modelBuilder.Configurations.Add(new OperadorValorGrupoMap());
            modelBuilder.Configurations.Add(new ParametroMap());
            modelBuilder.Configurations.Add(new ParametroPdvMap());
            modelBuilder.Configurations.Add(new ParcelamentoSubtipoRecebimentoMap());
            modelBuilder.Configurations.Add(new PdvMap());
            modelBuilder.Configurations.Add(new PedidoCompraMap());
            modelBuilder.Configurations.Add(new PedidoTransitoMap());
            modelBuilder.Configurations.Add(new PedidoVendaMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new PessoaRelacionamentoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ProdutoListaMap());
            modelBuilder.Configurations.Add(new ProdutoLojaMap());
            modelBuilder.Configurations.Add(new PromocaoMap());
            modelBuilder.Configurations.Add(new PropriedadeMap());
            modelBuilder.Configurations.Add(new PropriedadeProdutoMap());
            modelBuilder.Configurations.Add(new RecebimentoPdvMap());
            modelBuilder.Configurations.Add(new RecebimentoVendaMap());
            modelBuilder.Configurations.Add(new RedeTefMap());
            modelBuilder.Configurations.Add(new RegiaoMap());
            modelBuilder.Configurations.Add(new SerieNfMap());
            modelBuilder.Configurations.Add(new ServicoMap());
            modelBuilder.Configurations.Add(new SetorBalancaMap());
            modelBuilder.Configurations.Add(new SituacaoMap());
            modelBuilder.Configurations.Add(new SubtipoRecebimentoMap());
            modelBuilder.Configurations.Add(new TecladoRapidoMap());
            modelBuilder.Configurations.Add(new TecladoRapidoPdvMap());
            modelBuilder.Configurations.Add(new TeclaMicroTerminalMap());
            modelBuilder.Configurations.Add(new TelefoneMap());
            // modelBuilder.Configurations.Add(new TipocobrancaMap());
            modelBuilder.Configurations.Add(new TipoDespesaMap());
            modelBuilder.Configurations.Add(new TipoEnderecoMap());
            modelBuilder.Configurations.Add(new TipoEquipamentoMap());
            modelBuilder.Configurations.Add(new TipoGrupoMap());
            modelBuilder.Configurations.Add(new TipoMovimentoMap());
            modelBuilder.Configurations.Add(new TipoOcorrenciaMap());
            modelBuilder.Configurations.Add(new TipoParametroPdvMap());
            modelBuilder.Configurations.Add(new TipoRecebimentoMap());
            modelBuilder.Configurations.Add(new TipoSangriaMap());
            modelBuilder.Configurations.Add(new TransacaoEstoqueMap());
            modelBuilder.Configurations.Add(new TransportadorMap());
            modelBuilder.Configurations.Add(new TributacaoMap());
            modelBuilder.Configurations.Add(new UnidadeMap());
            modelBuilder.Configurations.Add(new ValorGrupoMap());
            modelBuilder.Configurations.Add(new ValorGrupoLojaMap());
            modelBuilder.Configurations.Add(new ValorMapaResumoMap());
            modelBuilder.Configurations.Add(new ValorProdutoMap());
            modelBuilder.Configurations.Add(new ValorPropriedadeMap());
            modelBuilder.Configurations.Add(new VeiculoMap());
            modelBuilder.Configurations.Add(new VendaMap());
            modelBuilder.Configurations.Add(new VendaCuboMap());
            modelBuilder.Configurations.Add(new VendaProdutoCuboMap());
            modelBuilder.Configurations.Add(new VendedorMap());
            modelBuilder.Configurations.Add(new VideoMap());
            modelBuilder.Configurations.Add(new VolumeMap());
            modelBuilder.Configurations.Add(new VolumeEntradaMap());
            modelBuilder.Configurations.Add(new VolumeVendaMap());
        }

        //        public Nullable<int> SPGERATRANSACAOESTOQUE(
        //            Nullable<int> LojaId = null,
        //            Nullable<int> CODPROD = null,
        //            Nullable<int> IDVLPR = null,
        //            Nullable<int> IDVLPR01 = null,
        //            Nullable<int> IDVLPR02 = null,
        //            Nullable<int> IDVLPR03 = null,
        //            Nullable<int> IDOPER = null,
        //            Nullable<int> CODFORN = null,
        //            Nullable<int> CODCLI = null,
        //            Nullable<int> CODLCES = null,
        //            Nullable<int> CODTPMV = null,
        //            Nullable<DateTime> DATATRES = null,
        //            Nullable<decimal> QTDETRES = null,
        //            Nullable<decimal> VALORTRES = null,
        //            string DOCTOTRES = null,
        //            string OPERACAOTRES = null,
        //            Nullable<int> IDITEN = null,
        //            Nullable<int> IDITVD = null,
        //            Nullable<int> IDITMV = null,
        //            Nullable<int> IDITIV = null
        //            )
        //        {
        //            SqlParameter CODLOJA = new SqlParameter("@CODLOJA", CODLOJA);
        //            SqlParameter CODPROD = new SqlParameter("@CODPROD", CODPROD);
        //            SqlParameter IDVLPR = new SqlParameter("@IDVLPR", IDVLPR);
        //            SqlParameter IDVLPR01 = new SqlParameter("@IDVLPR01", IDVLPR01);
        //            SqlParameter IDVLPR02 = new SqlParameter("@IDVLPR02", IDVLPR02);
        //            SqlParameter IDVLPR03 = new SqlParameter("@IDVLPR03", IDVLPR03);
        //            SqlParameter IDOPER = new SqlParameter("@IDOPER", IDOPER);
        //            SqlParameter CODFORN = new SqlParameter("@CODFORN", CODFORN);
        //            SqlParameter CODCLI = new SqlParameter("@CODCLI", CODCLI);
        //            SqlParameter CODLCES = new SqlParameter("@CODLCES", CODLCES);
        //            SqlParameter CODTPMV = new SqlParameter("@CODTPMV", CODTPMV);
        //            SqlParameter DATATRES = new SqlParameter("@DATATRES", DATATRES);
        //            SqlParameter QTDETRES = new SqlParameter("@QTDETRES", QTDETRES);
        //            SqlParameter VALORTRES = new SqlParameter("@VALORTRES", VALORTRES);
        //            SqlParameter DOCTOTRES = new SqlParameter("@DOCTOTRES", DOCTOTRES);
        //            SqlParameter OPERACAOTRES = new SqlParameter("@OPERACAOTRES", OPERACAOTRES);
        //            SqlParameter IDITEN = new SqlParameter("@IDITEN", IDITEN);
        //            SqlParameter IDITVD = new SqlParameter("@IDITVD", IDITVD);
        //            SqlParameter IDITMV = new SqlParameter("@IDITMV", IDITMV);
        //            SqlParameter IDITIV = new SqlParameter("@IDITIV", IDITIV);
        //            SqlParameter IDTRES = new SqlParameter("@IDTRES", SqlDbType.Int);

        //            IDTRES.Direction = ParameterDirection.Output;

        //            Database.ExecuteSqlCommand(@"EXEC SPGERATRANSACAOESTOQUE 
        //                                                                   @CODLOJA,
        //                                                                   @CODPROD,
        //                                                                   @IDVLPR,
        //                                                                   @IDVLPR01,
        //                                                                   @IDVLPR02,
        //                                                                   @IDVLPR03,
        //                                                                   @IDOPER,
        //                                                                   @CODFORN,
        //                                                                   @CODCLI,
        //                                                                   @CODLCES,
        //                                                                   @CODTPMV,
        //                                                                   @DATATRES,
        //                                                                   @QTDETRES,
        //                                                                   @VALORTRES,
        //                                                                   @DOCTOTRES,
        //                                                                   @OPERACAOTRES,
        //                                                                   @IDITEN,
        //                                                                   @IDITVD,
        //                                                                   @IDITMV,
        //                                                                   @IDITIV,
        //                                                                   @IDTRES",
        //                                                                    CODLOJA,
        //                                                                    CODPROD,
        //                                                                    IDVLPR,
        //                                                                    IDVLPR01,
        //                                                                    IDVLPR02,
        //                                                                    IDVLPR03,
        //                                                                    IDOPER,
        //                                                                    CODFORN,
        //                                                                    CODCLI,
        //                                                                    CODLCES,
        //                                                                    CODTPMV,
        //                                                                    DATATRES,
        //                                                                    QTDETRES,
        //                                                                    VALORTRES,
        //                                                                    DOCTOTRES,
        //                                                                    OPERACAOTRES,
        //                                                                    IDITEN,
        //                                                                    IDITVD,
        //                                                                    IDITMV,
        //                                                                    IDITIV,
        //                                                                    IDTRES);

        //            return (Nullable<int>)IDTRES.Value;
        //        }
    }
}