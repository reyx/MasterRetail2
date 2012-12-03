using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ContaCorrenteLoja
	{
        public int ContaCorrenteLojaId { get; set; }
		public Nullable<int> ContaCorrenteId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public virtual ContaCorrente ContaCorrente { get; set; }
		public virtual Loja Loja { get; set; }
	}
}

