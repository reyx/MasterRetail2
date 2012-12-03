using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class InstrucaoPdv
    {
        public int InstrucaoPdvId { get; set; }
        public Nullable<int> PdvId { get; set; }
        public Nullable<int> TabelaId { get; set; }
        public string Instrucao { get; set; }
        public string ValorChave { get; set; }
        public string Operacao { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public virtual Pdv Pdv { get; set; }
    }
}