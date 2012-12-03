using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class CupomFiscalNf
    {
        public int CupomFiscalNfId { get; set; }
        public Nullable<int> CupomFiscalId { get; set; }
        public Nullable<int> NfId { get; set; }
        public virtual CupomFiscal CupomFiscal { get; set; }
        public virtual NotaFiscal NotaFiscal { get; set; }
    }
}