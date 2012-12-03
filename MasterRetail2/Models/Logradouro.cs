using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class Logradouro
	{
        public Logradouro()
		{
            this.Enderecos = new List<Endereco>();
		}

        public int LogradouroId { get; set; }
		public string Nome { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }
	}
}