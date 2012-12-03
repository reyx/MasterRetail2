using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class HistoricoLancamento
    {
        public HistoricoLancamento()
        {
            this.Lancamentos = new List<Lancamento>();
        }

        public int HistoricoLancamentoId { get; set; }
        public string Descricao { get; set; }
        public string Operacao { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}