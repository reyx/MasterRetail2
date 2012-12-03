using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class VendaCubo
    {
        public int VendaCuboId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<decimal> ValorMercadoria { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public Nullable<decimal> Acrescimo { get; set; }
        public Nullable<decimal> TaxaEntrega { get; set; }
        public Nullable<decimal> Servico { get; set; }
        public Nullable<decimal> Ipi { get; set; }
        public Nullable<decimal> BaseIcms { get; set; }
        public Nullable<decimal> Icms { get; set; }
        public Nullable<int> Pessoas { get; set; }
        public string Data { get; set; }
        public Nullable<decimal> Devolucao { get; set; }
        public virtual Loja Loja { get; set; }
    }
}