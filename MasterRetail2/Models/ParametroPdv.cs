using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ParametroPdv
    {
        public int ParametroPdvId { get; set; }
        public Nullable<int> PdvId { get; set; }
        public Nullable<int> TipoParametroPdvId { get; set; }
        public string Valor { get; set; }
        public string Texto { get; set; }
        public virtual Pdv Pdv { get; set; }
        public virtual TipoParametroPdv TipoParametroPdv { get; set; }
    }
}