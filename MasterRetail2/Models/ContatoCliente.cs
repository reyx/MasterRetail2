using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ContatoCliente
    {
        public int ContatoClienteId { get; set; }
        public string Tipo { get; set; }
        public System.DateTime Data { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}