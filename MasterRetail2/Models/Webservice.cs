using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Webservice
    {
        public Webservice()
        {
            this.Ufs = new List<UfWebservice>();
        }

        public int WebserviceId { get; set; }
        public string Servico { get; set; }
        public string Url { get; set; }
        public string Versao { get; set; }
        public string Ambiente { get; set; }
        public virtual ICollection<UfWebservice> Ufs { get; set; }
    }
}