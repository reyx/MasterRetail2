using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class SerieNf
    {
        public SerieNf()
        {
            this.NotasFiscais = new List<NotaFiscal>();
        }

        public int SerieNfId { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<int> LojaId { get; set; }
        public string PrincipalString { get; set; }
        public bool Principal
        {
            get { return PrincipalString == "A"; }
            set { PrincipalString = value ? "A" : "B"; }
        }
        public virtual Loja Loja { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
    }
}