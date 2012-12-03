using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class VolumeEntrada
    {
        public int VolumeEntradaId { get; set; }
        public Nullable<int> VolumeId { get; set; }
        public Nullable<int> EntradaId { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual Volume Volume { get; set; }
    }
}