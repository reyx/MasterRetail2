using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Ncm
    {
        public Ncm()
        {
            this.NcmsCnae = new List<NcmCnae>();
            this.NcmsUfRegimeTributario = new List<NcmUfRegimeTributario>();
        }

        public int NcmId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Capitulo { get; set; }
        public string Posicao { get; set; }
        public string Subposicao { get; set; }
        public string Item { get; set; }
        public string Subitem { get; set; }
        public Nullable<decimal> Aliquota { get; set; }
        public virtual ICollection<NcmCnae> NcmsCnae { get; set; }
        public virtual ICollection<NcmUfRegimeTributario> NcmsUfRegimeTributario { get; set; }
    }
}