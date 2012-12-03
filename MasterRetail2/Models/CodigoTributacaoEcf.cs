using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class CodigoTributacaoEcf
	{
        public int CodigoTributacaoEcfId { get; set; }
		public Nullable<int> EcfId { get; set; }
		public Nullable<int> CodigoTributacaoId { get; set; }
		public string Comando { get; set; }
		public string TipoComendo{ get; set; }
		public Nullable<int> TamanhoComando{ get; set; }
		public virtual CodigoTributacao CodigoTributacao { get; set; }
		public virtual Ecf Ecf { get; set; }
	}
}