using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class OcorrenciaPdv
    {
        public int OcorrenciaPdvId { get; set; }
        public Nullable<int> MovimentoPdvId { get; set; }
        public Nullable<int> TipoOcorrenciaId { get; set; }
        public Nullable<int> RecebimentoPdvId { get; set; }
        public Nullable<int> SupervisorId { get; set; }
        public Nullable<int> TipoSangriaId { get; set; }
        public Nullable<int> TipoDespesaId { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Observacao { get; set; }
        public virtual MovimentoPdv MovimentoPdv { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual RecebimentoPdv RecebimentoPdv { get; set; }
        public virtual TipoDespesa TipoDespesa { get; set; }
        public virtual TipoOcorrencia TipoOcorrencia { get; set; }
        public virtual TipoSangria TipoSangria { get; set; }
    }
}