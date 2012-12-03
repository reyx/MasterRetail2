using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Agencia
	{
        public Agencia()
		{
            this.ContasCorrentes = new List<ContaCorrente>();
		}

		public int AgenciaId { get; set; }
		public Nullable<int> Numero{ get; set; }
		public string Digito { get; set; }
		public string Nome { get; set; }
		public string Observacao { get; set; }
		public Nullable<int> BancoId{ get; set; }
        public virtual ICollection<ContaCorrente> ContasCorrentes { get; set; }
        public virtual Banco Banco { get; set; }
	}
}

