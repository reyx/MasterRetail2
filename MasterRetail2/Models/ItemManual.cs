using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemManual
    {
        public ItemManual()
        {
            this.ImagensItemManual = new List<ImagemItemManual>();
        }

        public int ItemManualId { get; set; }
        public Nullable<int> ManualId { get; set; }
        public Nullable<int> FuncaoProgramaId { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public virtual FuncaoPrograma FuncaoPrograma { get; set; }
        public virtual ICollection<ImagemItemManual> ImagensItemManual { get; set; }
        public virtual Manual Manual { get; set; }
    }
}