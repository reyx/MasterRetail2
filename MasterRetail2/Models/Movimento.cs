using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Movimento
	{
        public Movimento()
		{
			this.ItensMovimento = new List<ItemMovimento>();
		}

        public int MovimentoId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<System.DateTime> Data { get; set; }
		public string Controle { get; set; }
		public Nullable<int> OperadorId { get; set; }
		public virtual ICollection<ItemMovimento> ItensMovimento { get; set; }
		public virtual Loja Loja { get; set; }
		public virtual Operador Operador { get; set; }
	}
}