using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class FuncaoOperador
	{
        public int FuncaoOperadorId { get; set; }
		public Nullable<int> OperadorId { get; set; }
		public Nullable<int> FuncaoProgramaId { get; set; }
		public string PermitidoString { get; set; }
        public bool Permitido
        {
            get { return PermitidoString == "A"; }
            set { PermitidoString = value ? "A" : "B"; }
        }
		public virtual Operador Operador { get; set; }
	}
}