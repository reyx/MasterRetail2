using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class OperadorValorGrupo
    {
        public int OperadorValorGrupoId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> ValorGrupoId { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual ValorGrupo ValorGrupo { get; set; }
    }
}