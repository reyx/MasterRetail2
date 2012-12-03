using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class CupomFiscal
    {
        public CupomFiscal()
        {
            this.CuponsFiscaisNf = new List<CupomFiscalNf>();
        }

        public int CupomFiscalId { get; set; }
        public Nullable<int> EcfId { get; set; }
        public Nullable<int> Coo { get; set; }
        public string Modelo { get; set; }
        public virtual ICollection<CupomFiscalNf> CuponsFiscaisNf { get; set; }
    }
}