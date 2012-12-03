using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class DeclaracaoImportacao
	{
        public DeclaracaoImportacao()
		{
			this.Adicoes = new List<Adicao>();
		}

        public int DeclaracaoImportacaoId { get; set; }
		public string LocalDesembargo { get; set; }
		public Nullable<int> UfId { get; set; }
		public Nullable<System.DateTime> DataDesembargo { get; set; }
		public Nullable<int> CodigoExportacao { get; set; }
		public Nullable<int> VendaId { get; set; }
		public virtual ICollection<Adicao> Adicoes { get; set; }
		public virtual Venda Venda { get; set; }
	}
}

