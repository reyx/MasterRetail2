using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TecladoRapidoPdv
    {
        public int TecladoRapidoPdvId { get; set; }
        public Nullable<int> PdvId { get; set; }
        public Nullable<int> TecladoRapidoId { get; set; }
        public Nullable<int> Ordem { get; set; }
        public virtual Pdv Pdv { get; set; }
        public virtual TecladoRapido TecladoRapido { get; set; }
    }
}