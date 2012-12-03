using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class VendaProdutoCubo
    {
        public int VendaProdutoCuboId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ValorProdutoId { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<decimal> Preco { get; set; }
        public Nullable<decimal> Custo { get; set; }
        public string Data { get; set; }
        public Nullable<decimal> Devolucao { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ValorProduto ValorProduto { get; set; }
    }
}