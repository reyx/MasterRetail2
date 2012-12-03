using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class TipoMovimento
    {
        public TipoMovimento()
        {
            this.ItensMovimento = new List<ItemMovimento>();
            this.ItensMovimentoDestino = new List<ItemMovimento>();
            this.Produtos = new List<Produto>();
            this.ProdutosAssociados = new List<Produto>();
            this.TiposMovimento = new List<TipoMovimento>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int TipoMovimentoId { get; set; }
        public string Descricao { get; set; }
        public string OperacaoProduto { get; set; }
        public string OperacaoComponente { get; set; }
        public Nullable<int> TipoMovimentoAssociadoId { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }
        public virtual ICollection<ItemMovimento> ItensMovimentoDestino{ get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Produto> ProdutosAssociados { get; set; }
        public virtual ICollection<TipoMovimento> TiposMovimento { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual TipoMovimento TipoMovimentoAssociado { get; set; }
    }
}