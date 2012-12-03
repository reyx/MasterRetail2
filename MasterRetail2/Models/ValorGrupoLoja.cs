using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ValorGrupoLoja
    {
        public int ValorGrupoLojaId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ValorGrupoId { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ValorGrupo ValorGrupo { get; set; }
    }
}