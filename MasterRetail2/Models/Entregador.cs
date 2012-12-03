using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Entregador
    {
        public Entregador()
        {
            this.Vendas = new List<Venda>();
        }

        public int EntregadorId { get; set; }
        public string AtivoString { get; set; }
		public bool Ativo
		{
			get { return AtivoString == "A"; }
			set { AtivoString = value ? "A" : "B"; }
		}
        public Nullable<int> PessoaId { get; set; }
        public virtual ICollection<Venda> Vendas { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}