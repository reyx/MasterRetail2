using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Ecf
	{
	    public Ecf()
		{
            this.CodigosTributacaoEcf = new List<CodigoTributacaoEcf>();
            this.MapasResumo = new List<MapaResumo>();
            this.Pdvs = new List<Pdv>();
		}

        public int EcfId { get; set; }
		public Nullable<int> ModeloEcfId { get; set; }
		public string Serie { get; set; }
		public Nullable<int> Numero{ get; set; }
		public string Calculo { get; set; }
		public string GrupoSangria { get; set; }
		public string CodigoSangria { get; set; }
		public string GrupoDeposito { get; set; }
		public string CodigoDeposito { get; set; }
        public virtual ICollection<CodigoTributacaoEcf> CodigosTributacaoEcf { get; set; }
        public virtual ICollection<MapaResumo> MapasResumo { get; set; }
		public virtual ICollection<Pdv> Pdvs { get; set; }
        public virtual ModeloEcf ModeloEcf { get; set; }
	}
}

