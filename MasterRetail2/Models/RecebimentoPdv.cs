using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class RecebimentoPdv
    {
        public RecebimentoPdv()
        {
            this.OcorrenciasPdv = new List<OcorrenciaPdv>();
        }

        public int RecebimentoPdvId { get; set; }
        public Nullable<int> MovimentoPdvId { get; set; }
        public Nullable<int> TipoRecebimentoId { get; set; }
        public Nullable<int> SubtipoRecebimentoId { get; set; }
        public Nullable<int> ParcelamentoSubtipoRecebimentoId { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Deposito { get; set; }
        public Nullable<decimal> Sangria { get; set; }
        public Nullable<decimal> ValorLiquido { get; set; }
        public Nullable<decimal> ValorReal { get; set; }
        public virtual MovimentoPdv MovimentoPdv { get; set; }
        public virtual ICollection<OcorrenciaPdv> OcorrenciasPdv { get; set; }
    }
}