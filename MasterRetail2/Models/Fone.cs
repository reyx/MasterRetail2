using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Fone
    {
        public int FoneId { get; set; }
        public string Numero { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}