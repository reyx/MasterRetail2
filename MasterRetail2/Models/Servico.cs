using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Servico
    {
        public Servico()
        {
            this.Produtos = new List<Produto>();
        }

        public int ServicoId { get; set; }
        public Nullable<int> Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}