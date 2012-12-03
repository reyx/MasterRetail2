using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class GrupoFaturamento
	{
        public GrupoFaturamento()
		{
            this.Produtos = new List<Produto>();
		}

        public int GrupoFaturamentoId { get; set; }
		public string Descricao { get; set; }
        public string Cf { get; set; }
        public string Cst{ get; set; }
        public Nullable<int> UnidadeId { get; set; }
		public virtual ICollection<Produto> Produtos { get; set; }
        public virtual Unidade Unidade { get; set; }
	}
}