using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TecladoRapido
    {
        public TecladoRapido()
        {
            this.Teclas = new List<ItemTecladoRapido>();
            this.Pdvs = new List<TecladoRapidoPdv>();
        }

        public int TecladoRapidoId { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Icone { get; set; }
        public Nullable<int> Ordem { get; set; }
        public virtual ICollection<ItemTecladoRapido> Teclas { get; set; }
        public virtual ICollection<TecladoRapidoPdv> Pdvs { get; set; }
    }
}