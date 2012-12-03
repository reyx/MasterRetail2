using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Cnae
    {
        public Cnae()
        {
            this.NcmsCnae = new List<NcmCnae>();
        }

        public int CnaeId { get; set; }
        public string Secao { get; set; }
        public string Divisao { get; set; }
        public string Grupo { get; set; }
        public string Classe { get; set; }
        public string Subclasse { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<NcmCnae> NcmsCnae { get; set; }
    }
}