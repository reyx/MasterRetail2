using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Cidade
    {
        public Cidade()
        {
            this.Bairros = new List<Bairro>();
        }

        public int CidadeId { get; set; }
        public int UfId { get; set; }
        public string Nome { get; set; }
        public Nullable<decimal> CodigoIbge { get; set; }
        public virtual ICollection<Bairro> Bairros { get; set; }
        public virtual Uf Uf { get; set; }
    }
}