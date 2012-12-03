using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class GrauRelacionamento
    {
        public GrauRelacionamento()
        {
            this.PessoasRelacionamento = new List<PessoaRelacionamento>();
        }

        public int GrauRelacionamentoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<PessoaRelacionamento> PessoasRelacionamento { get; set; }
    }
}