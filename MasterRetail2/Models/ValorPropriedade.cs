using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ValorPropriedade
    {
        public ValorPropriedade()
        {
            this.ValoresProduto1 = new List<ValorProduto>();
            this.ValoresProduto2 = new List<ValorProduto>();
            this.ValoresProduto3 = new List<ValorProduto>();
        }

        public int ValorPropriedadeId { get; set; }
        public Nullable<int> PropriedadeId { get; set; }
        public string Descricao { get; set; }
        public virtual Propriedade Propriedade { get; set; }
        public virtual ICollection<ValorProduto> ValoresProduto1 { get; set; }
        public virtual ICollection<ValorProduto> ValoresProduto2 { get; set; }
        public virtual ICollection<ValorProduto> ValoresProduto3 { get; set; }
    }
}