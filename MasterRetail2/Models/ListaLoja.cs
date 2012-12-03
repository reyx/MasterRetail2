using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ListaLoja
    {
        public int ListaLojaId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ListaId { get; set; }
        public string Preco { get; set; }
        public virtual Lista Lista { get; set; }
        public virtual Loja Loja { get; set; }
    }
}