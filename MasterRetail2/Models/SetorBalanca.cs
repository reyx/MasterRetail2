using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class SetorBalanca
    {
        public SetorBalanca()
        {
            this.Produtos = new List<Produto>();
        }

        public int SetorBalancaId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}