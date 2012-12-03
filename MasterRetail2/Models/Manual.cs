using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Manual
    {
        public Manual()
        {
            this.Itens = new List<ItemManual>();
        }

        public int ManualId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ItemManual> Itens { get; set; }
    }
}