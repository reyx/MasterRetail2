using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Situacao
    {
        public Situacao()
        {
            this.Clientes = new List<Cliente>();
        }

        public int SituacaoId { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Acao { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}