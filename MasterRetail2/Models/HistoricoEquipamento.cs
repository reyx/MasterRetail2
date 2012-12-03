using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class HistoricoEquipamento
	{
        public HistoricoEquipamento()
		{
			this.MovimentacoesEquipamento = new List<MovimentacaoEquipamento>();
		}

        public int HistoricoEquipamentoId { get; set; }
		public string Descricao { get; set; }
		public virtual ICollection<MovimentacaoEquipamento> MovimentacoesEquipamento { get; set; }
	}
}