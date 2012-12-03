using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class RegimeTributario
    {
        public RegimeTributario()
        {
            this.NcmsUfRegimeTributario = new List<NcmUfRegimeTributario>();
        }

        public int RegimeTributarioId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<NcmUfRegimeTributario> NcmsUfRegimeTributario { get; set; }
    }
}