using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class TransacaoEstoque
	{
        public int TransacaoEstoqueId { get; set; }
		public Nullable<int> OperadorId { get; set; }
		public Nullable<int> FornecedorId { get; set; }
		public Nullable<int> ClienteId { get; set; }
		public Nullable<int> LocalEstoqueId { get; set; }
		public Nullable<int> TipoMovimentoId { get; set; }
		public Nullable<int> ValorProdutoId { get; set; }
		public Nullable<System.DateTime> Data { get; set; }
		public Nullable<decimal> Quantidade { get; set; }
		public Nullable<decimal> EstoqueAnterior { get; set; }
		public Nullable<decimal> EstoqueAtual { get; set; }
		public Nullable<decimal> Valor { get; set; }
		public string Documento { get; set; }
		public string Operacao { get; set; }
		public Nullable<int> ItemEntradaId { get; set; }
		public Nullable<int> ItemVendaId { get; set; }
		public Nullable<System.DateTime> DataSistema { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<int> ItemMovimentoId { get; set; }
		public Nullable<int> ItemInventarioId { get; set; }
		public virtual Cliente Cliente { get; set; }
		public virtual Fornecedor Fornecedor { get; set; }
		public virtual ItemEntrada ItemEntrada { get; set; }
		public virtual ItemInventario ItemInventario { get; set; }
		public virtual ItemMovimento ItemMovimento { get; set; }
		public virtual ItemVenda ItemVenda { get; set; }
		public virtual LocalEstoque LocalEstoque { get; set; }
		public virtual Loja Loja { get; set; }
		public virtual Operador Operador { get; set; }
        public virtual TipoMovimento TipoMovimento { get; set; }
		public virtual ValorProduto ValorProduto { get; set; }
	}
}