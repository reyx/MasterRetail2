using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ParcelamentoSubtipoRecebimento
    {
        public ParcelamentoSubtipoRecebimento()
        {
            this.RecebimentosVenda = new List<RecebimentoVenda>();
        }

        public int ParcelamentoSubtipoRecebimentoId { get; set; }
        public Nullable<int> SubtipoRecebimentoId { get; set; }
        public string Decricao { get; set; }
        public string SequenciaNumerica { get; set; }
        public string SequenciaLetra { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public Nullable<int> Dia1 { get; set; }
        public Nullable<int> Dia2 { get; set; }
        public Nullable<int> Dia3 { get; set; }
        public Nullable<int> Dia4 { get; set; }
        public Nullable<int> Dia5 { get; set; }
        public Nullable<int> Dia6 { get; set; }
        public virtual ICollection<RecebimentoVenda> RecebimentosVenda { get; set; }
        public virtual SubtipoRecebimento SubtipoRecebimento { get; set; }
    }
}