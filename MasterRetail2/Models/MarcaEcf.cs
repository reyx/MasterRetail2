using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class MarcaEcf
    {
        public MarcaEcf()
        {
            this.ModelosEcf = new List<ModeloEcf>();
        }

        public int MarcaEcfId { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public virtual ICollection<ModeloEcf> ModelosEcf { get; set; }
    }
}