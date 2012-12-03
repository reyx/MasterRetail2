using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemMovimento
    {
        public ItemMovimento()
        {
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int ItemMovimentoId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> MovimentoId { get; set; }
        public Nullable<int> ValorProdutoId { get; set; }
        public Nullable<int> TipoMovimentoId { get; set; }
        public Nullable<int> TipoMovimentoDestinoId { get; set; }
        public Nullable<int> LocalEstoqueId { get; set; }
        public Nullable<int> LocalEstoqueDestinoId { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<int> LojaDestinoId { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual LocalEstoque LocalEstoque { get; set; }
        public virtual LocalEstoque LocalEstoqueDestino { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Movimento Movimento { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual TipoMovimento TipoMovimento { get; set; }
        public virtual TipoMovimento TipoMovimentoDestino { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
    }
}