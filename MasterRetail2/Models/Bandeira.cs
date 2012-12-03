using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Bandeira
	{
        public Bandeira()
		{
            this.ContasReceber = new List<ContaReceber>();
            this.SubtiposRecebimento = new List<SubtipoRecebimento>();
		}

		public int BandeiraId { get; set; }
		public Nullable<int> PessoaId { get; set; }
        public string AtivoString { get; set; }
        public bool Ativo
        {
            get { return AtivoString == "A"; }
            set { AtivoString = value ? "A" : "B"; }
        }
		public Nullable<int> Icone { get; set; }
        public virtual ICollection<ContaReceber> ContasReceber { get; set; }
        public virtual ICollection<SubtipoRecebimento> SubtiposRecebimento { get; set; }
        public virtual Pessoa Pessoa { get; set; }
	}
}

