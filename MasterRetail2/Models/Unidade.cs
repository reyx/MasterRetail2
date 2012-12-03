using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Unidade
    {
        public Unidade()
        {
            this.Produtos = new List<Produto>();
            this.Embalagens = new List<Produto>();
            this.GruposFaturamento = new List<GrupoFaturamento>();
        }

        public int UnidadeId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Produto> Embalagens { get; set; }
        public virtual ICollection<GrupoFaturamento> GruposFaturamento { get; set; }
    }
}