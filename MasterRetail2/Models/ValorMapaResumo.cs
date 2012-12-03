using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ValorMapaResumo
    {
        public int ValorMapaResumoId { get; set; }
        public Nullable<int> MapaResumoId { get; set; }
        public string Codigo { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Taxa { get; set; }
        public virtual MapaResumo MapaResumo { get; set; }
    }
}