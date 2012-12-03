using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class LogAcesso
    {
        public int LogAcessoId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public string Ip { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Acao { get; set; }
        public virtual Operador Operador { get; set; }
    }
}