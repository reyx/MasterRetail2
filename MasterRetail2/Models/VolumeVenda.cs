using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class VolumeVenda
	{
        public int VolumeVendaId { get; set; }
		public Nullable<int> VolumeId{ get; set; }
		public Nullable<int> VendaId { get; set; }
		public virtual Venda Venda { get; set; }
		public virtual Volume Volume { get; set; }
	}
}