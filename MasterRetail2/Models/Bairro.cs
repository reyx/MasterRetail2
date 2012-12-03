using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class Bairro
	{
        public Bairro()
		{
            this.Enderecos = new List<Endereco>();
		}

		public int BairroId { get; set; }
		public int CidadeId { get; set; }
		public string Nome { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
        public virtual Cidade Cidade { get; set; }
	}
}

