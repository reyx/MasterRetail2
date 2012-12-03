using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Propriedade
    {
        public Propriedade()
        {
            this.Produtos = new List<PropriedadeProduto>();
            this.Valores = new List<ValorPropriedade>();
        }

        public int PropriedadeId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PropriedadeProduto> Produtos { get; set; }
        public virtual ICollection<ValorPropriedade> Valores { get; set; }
    }
}