using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class Banco
	{
        public Banco()
		{
            this.Agencias = new List<Agencia>();
            this.LayoutsBoleto = new List<LayoutBoleto>();
            this.LayoutsCnab = new List<LayoutCnab>();
		}

		public int BancoId { get; set; }
		public string Nome { get; set; }
        public virtual ICollection<Agencia> Agencias { get; set; }
        public virtual ICollection<LayoutBoleto> LayoutsBoleto { get; set; }
        public virtual ICollection<LayoutCnab> LayoutsCnab { get; set; }
	}
}