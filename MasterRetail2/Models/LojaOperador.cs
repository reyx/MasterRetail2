using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class LojaOperador
    {
        public int LojaOperadorId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public string NivelLoja { get; set; }
        public string NivelPdv { get; set; }
        public string NivelRetaguarda { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
    }
}