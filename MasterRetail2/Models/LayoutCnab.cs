using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class LayoutCnab
	{
        public int LayoutCnabId { get; set; }
		public Nullable<int> BancoId { get; set; }
		public Nullable<int> ContaCorrenteId { get; set; }
		public Nullable<int> TipoRegistro { get; set; }
		public Nullable<int> Sequencia{ get; set; }
		public string Campo { get; set; }
		public Nullable<int> SomaDias { get; set; }
		public Nullable<int> Tamanho { get; set; }
		public string Alinhamento { get; set; }
		public string Carpre { get; set; }
		public string Texto { get; set; }
		public virtual Banco Banco { get; set; }
		public virtual ContaCorrente ContaCorrente { get; set; }
	}
}

