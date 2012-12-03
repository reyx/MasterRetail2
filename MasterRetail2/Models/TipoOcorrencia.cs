using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TipoOcorrencia
    {
        public TipoOcorrencia()
        {
            this.OcorrenciasPdv = new List<OcorrenciaPdv>();
        }

        public int TipoOcorrenciaId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<OcorrenciaPdv> OcorrenciasPdv { get; set; }
    }
}