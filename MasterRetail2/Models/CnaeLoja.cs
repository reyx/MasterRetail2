using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class CnaeLoja
	{
        public int CnaeLojaId { get; set; }
        public Nullable<int> CnaeId { get; set; }
		public Nullable<int> LojaId { get; set; }
        public virtual Loja Loja { get; set; }
	}
}