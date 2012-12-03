using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TipoParametroPdv
    {
        public TipoParametroPdv()
        {
            this.ParametrosPdv = new List<ParametroPdv>();
        }

        public int TipoParametroPdvId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public virtual ICollection<ParametroPdv> ParametrosPdv { get; set; }
    }
}