using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class FoneDialUp
    {
        public int FoneDialUpId { get; set; }
        public Nullable<int> CidadeId { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
    }
}