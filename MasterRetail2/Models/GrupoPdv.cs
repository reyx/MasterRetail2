using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class GrupoPdv
    {
        public GrupoPdv()
        {
            this.Pdvs = new List<Pdv>();
        }

        public int GrupoPdvId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Pdv> Pdvs { get; set; }
    }
}