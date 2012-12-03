using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class GrupoProduto
    {
        public GrupoProduto()
        {
            this.Produtos = new List<Produto>();
        }

        public int GrupoProdutoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}