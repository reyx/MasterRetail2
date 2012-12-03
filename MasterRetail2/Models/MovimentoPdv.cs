using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class MovimentoPdv
	{
        public MovimentoPdv()
		{
            this.Ocorrencias = new List<OcorrenciaPdv>();
            this.Recebimentos = new List<RecebimentoPdv>();
			this.Vendas = new List<Venda>();
		}

        public int MovimentoPdvId { get; set; }
		public Nullable<System.DateTime> Data { get; set; }
		public Nullable<int> Turno { get; set; }
		public Nullable<int> PdvId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<int> OperadorId { get; set; }
		public string Situacao { get; set; }
		public Nullable<System.DateTime> HoraAbertura{ get; set; }
		public Nullable<System.DateTime> HoraFechamento { get; set; }
		public Nullable<int> SupervisorAberturaId{ get; set; }
        public Nullable<int> SupervisorFechamentoId { get; set; }
		public Nullable<decimal> Acrescimo { get; set; }
		public virtual Loja Loja { get; set; }
        public virtual ICollection<OcorrenciaPdv> Ocorrencias { get; set; }
		public virtual ICollection<RecebimentoPdv> Recebimentos { get; set; }
		public virtual ICollection<Venda> Vendas { get; set; }
		public virtual Operador Operador { get; set; }
        public virtual Operador SupervisorAbertura { get; set; }
        public virtual Operador SupervisorFechamento { get; set; }
        public virtual Pdv Pdv { get; set; }
	}
}