using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class NumeroMapaResumo
    {
        public int NumeroMapaResumoId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<int> LojaId { get; set; }
        public virtual Loja Loja { get; set; }
    }
}