using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Documento
	{
        public int DocumentoId { get; set; }
		public string Descricao { get; set; }
		public string ObrigatorioString { get; set; }
        public bool Obrigatorio
        {
            get { return ObrigatorioString == "A"; }
            set { ObrigatorioString = value ? "A" : "B"; }
        }
		public string ChecadoString { get; set; }
        public bool Checado
        {
            get { return ChecadoString == "A"; }
            set { ChecadoString = value ? "A" : "B"; }
        }
	}
}