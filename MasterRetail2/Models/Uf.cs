using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Uf
    {
        public Uf()
        {
            this.Cidades = new List<Cidade>();
            this.NcmsUfRegimeTributario = new List<NcmUfRegimeTributario>();
            this.Webservices = new List<UfWebservice>();
        }

        public int UfId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public Nullable<decimal> CodigoIbge { get; set; }
        public virtual ICollection<Cidade> Cidades { get; set; }
        public virtual ICollection<NcmUfRegimeTributario> NcmsUfRegimeTributario { get; set; }
        public virtual ICollection<UfWebservice> Webservices { get; set; }
    }
}