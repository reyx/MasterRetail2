using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class TipoSangria
    {
        public TipoSangria()
        {
            this.OcorrenciasPdv = new List<OcorrenciaPdv>();
        }

        public int TipoSangriaId { get; set; }
        public string Descricao { get; set; }
        public string Autorizacao { get; set; }
        public string Emissao { get; set; }
        public virtual ICollection<OcorrenciaPdv> OcorrenciasPdv { get; set; }
    }
}