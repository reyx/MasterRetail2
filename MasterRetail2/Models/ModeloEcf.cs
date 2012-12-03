using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class ModeloEcf
	{
        public ModeloEcf()
		{
			this.Ecfs = new List<Ecf>();
		}

        public int ModeloEcfId { get; set; }
        public Nullable<int> MarcaEcfId { get; set; }
		public string Descricao { get; set; }
		public string Observacao { get; set; }
        public virtual ICollection<Ecf> Ecfs { get; set; }
        public virtual MarcaEcf MarcaEcf { get; set; }
	}
}