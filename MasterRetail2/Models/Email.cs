using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Email
    {
        public int EmailId { get; set; }
        public string Endereco { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}