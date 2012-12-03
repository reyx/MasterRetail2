using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Parametro
    {
        public int ParametroId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> TipoParametroId { get; set; }
        public string Valor { get; set; }
        public string Texto { get; set; }
        public virtual Loja Loja { get; set; }
    }
}