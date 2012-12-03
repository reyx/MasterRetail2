using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class UfWebservice
    {
        public int UfWebserviceId { get; set; }
        public Nullable<int> UfId { get; set; }
        public Nullable<int> WebserviceId { get; set; }
        public virtual Uf Uf { get; set; }
        public virtual Webservice Webservice { get; set; }
    }
}