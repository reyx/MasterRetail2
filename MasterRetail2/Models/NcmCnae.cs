using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class NcmCnae
	{
        public int NcmCnaeId { get; set; }
		public Nullable<int> CnaeId { get; set; }
		public Nullable<int> NcmId { get; set; }
        public virtual Cnae Cnae { get; set; }
        public virtual Ncm Ncm { get; set; }
	}
}