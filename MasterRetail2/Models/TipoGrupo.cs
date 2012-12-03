using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class TipoGrupo
    {
        public TipoGrupo()
        {
            this.ValoresGrupo = new List<ValorGrupo>();
        }

        public int TipoGrupoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ValorGrupo> ValoresGrupo { get; set; }
    }
}