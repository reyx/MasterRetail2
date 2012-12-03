using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class Adicao
	{
		public int AdicaoId { get; set; }
		public Nullable<int> Numero { get; set; }
		public Nullable<int> Item { get; set; }
		public Nullable<int> CodigoFabrica { get; set; }
		public Nullable<decimal> Desconto { get; set; }
		public Nullable<int> DeclaracaoImportacaoId { get; set; }
        public virtual DeclaracaoImportacao DeclaracaoImportacao { get; set; }
	}
}

