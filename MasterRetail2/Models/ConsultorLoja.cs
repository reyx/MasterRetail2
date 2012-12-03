using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ConsultorLoja
	{
        public int ConsultorLojaId { get; set; }
		public Nullable<int> ConsultorId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public virtual Consultor Consultor { get; set; }
		public virtual Loja Loja { get; set; }
	}
}

