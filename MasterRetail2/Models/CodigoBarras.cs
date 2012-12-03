using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class CodigoBarras
	{
        public int CodigoBarraId { get; set; }
		public string Codigo { get; set; }
		public Nullable<int> ProdutoId { get; set; }
        public string PrincipalString { get; set; }
        public bool Principal
        {
            get { return PrincipalString == "A"; }
            set { PrincipalString = value ? "A" : "B"; }
        }
		public virtual Produto Produto { get; set; }
	}
}