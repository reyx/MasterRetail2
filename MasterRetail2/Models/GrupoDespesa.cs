using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class GrupoDespesa
	{
        public GrupoDespesa()
		{
            this.TiposDespesa = new List<TipoDespesa>();
		}

        public int GrupoDespesaId { get; set; }
		public Nullable<int> Grupo{ get; set; }
		public string Descricao { get; set; }
        public virtual ICollection<TipoDespesa> TiposDespesa { get; set; }
	}
}