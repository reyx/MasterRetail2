using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class NcmUfRegimeTributario
    {
        public int NcmUfRegimeTributarioId { get; set; }
        public Nullable<int> NcmId { get; set; }
        public Nullable<int> UfId { get; set; }
        public Nullable<int> RegimeTributarioId { get; set; }
        public Nullable<decimal> Mva { get; set; }
        public Nullable<decimal> Reducao { get; set; }
        public Nullable<decimal> Aliquota { get; set; }
        public Nullable<decimal> ReducaoSt { get; set; }
        public Nullable<decimal> AliquotaSt { get; set; }
        public virtual Ncm Ncm { get; set; }
        public virtual RegimeTributario RegimeTributario { get; set; }
        public virtual Uf Uf { get; set; }
    }
}