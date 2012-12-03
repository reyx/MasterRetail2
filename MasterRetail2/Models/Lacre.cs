using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Lacre
    {
        public int LacreId { get; set; }
        public string Numero { get; set; }
        public Nullable<int> VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
    }
}