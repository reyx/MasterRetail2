using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Endereco
	{
        public int EnderecoId { get; set; }
		public Nullable<int> LogradouroId { get; set; }
		public string Nome { get; set; }
		public string Cep { get; set; }
		public int BairroId { get; set; }
		public virtual Bairro Bairro { get; set; }
		public virtual Logradouro Logradouro { get; set; }
	}
}