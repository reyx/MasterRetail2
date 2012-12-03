using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class PessoaRelacionamento
    {
        public int PessoaRelacionamentoId { get; set; }
        public Nullable<int> PessoaAId { get; set; }
        public Nullable<int> PessoaBId { get; set; }
        public Nullable<int> GrauRelacionamentoId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual GrauRelacionamento GrauRelacionamento { get; set; }
        public virtual Pessoa PessoaA { get; set; }
        public virtual Pessoa PessoaB { get; set; }
    }
}