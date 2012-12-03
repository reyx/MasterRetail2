using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class RecebimentoVenda
    {
        public int RecebimentoVendaId { get; set; }
        public Nullable<int> VendaId { get; set; }
        public Nullable<int> Sequencia { get; set; }
        public Nullable<int> TipoRecebimentoId { get; set; }
        public Nullable<int> SubtipoRecebimentoId { get; set; }
        public Nullable<int> ParcelamentoSubtipoRecebimentoId { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Liquido { get; set; }
        public virtual ParcelamentoSubtipoRecebimento ParcelamentoSubtipoRecebimento { get; set; }
        public virtual SubtipoRecebimento SubtipoRecebimento { get; set; }
        public virtual TipoRecebimento TipoRecebimento { get; set; }
        public virtual Venda Venda { get; set; }
    }
}