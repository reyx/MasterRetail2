using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class DocumentoPessoa
	{
        public int DocumentoPessoaId { get; set; }
		public Nullable<int> PessoaId { get; set; }
		public Nullable<int> DocumentoId { get; set; }
		public string Valor { get; set; }
		public Nullable<int> UfId { get; set; }
		public virtual Pessoa Pessoa { get; set; }
	}
}

