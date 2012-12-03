using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Link
    {
        public int LinkId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
        public Nullable<int> Ordem { get; set; }
        public Nullable<int> FuncaoProgramaId { get; set; }
        public virtual Operador Operador { get; set; }
    }
}