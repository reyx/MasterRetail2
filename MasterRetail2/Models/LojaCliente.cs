using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class LojaCliente
    {
        public int LojaClienteId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public int ClienteId { get; set; }
        public Nullable<int> SituacaoId { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Situacao Situacao { get; set; }
    }
}