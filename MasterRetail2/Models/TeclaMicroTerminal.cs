using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TeclaMicroTerminal
    {
        public int TeclaMicroTerminalId { get; set; }
        public Nullable<int> MicroTerminalId { get; set; }
        public Nullable<int> Tecla { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public virtual MicroTerminal MicroTerminal { get; set; }
        public virtual Produto Produto { get; set; }
    }
}