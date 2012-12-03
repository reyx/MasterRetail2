using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Consultor
    {
        public Consultor()
        {
            this.ConsultoresLojas = new List<ConsultorLoja>();
        }

        public int ConsultorId { get; set; }
        public string AtivoString { get; set; }
        public bool Ativo
        {
            get { return AtivoString == "A"; }
            set { AtivoString = value ? "A" : "B"; }
        }
        public Nullable<int> PessoaId { get; set; }
        public virtual ICollection<ConsultorLoja> ConsultoresLojas { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}