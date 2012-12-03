using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            this.ContasPagar = new List<ContaPagar>();
            this.Entradas = new List<Entrada>();
            this.FornecedorProdutos = new List<FornecedorProduto>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.PedidosCompra = new List<PedidoCompra>();
            this.Produtos = new List<Produto>();
            this.TransacoesEstoque = new List<TransacaoEstoque>();
        }

        public int FornecedorId { get; set; }
        public Nullable<int> PessoaId { get; set; }
        public string AtivoString { get; set; }
        public bool Ativo
        {
            get { return AtivoString == "A"; }
            set { AtivoString = value ? "A" : "B"; }
        }
        public virtual ICollection<ContaPagar> ContasPagar { get; set; }
        public virtual ICollection<Entrada> Entradas { get; set; }
        public virtual ICollection<FornecedorProduto> FornecedorProdutos { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<PedidoCompra> PedidosCompra { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<TransacaoEstoque> TransacoesEstoque { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}