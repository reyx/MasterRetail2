using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Kit
    {
        public Kit()
        {
            this.Itens = new List<ItemKit>();
        }

        public int KitId { get; set; }
        public Nullable<int> Codigo { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Lote { get; set; }
        public string Observacao { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<int> LojaId { get; set; }
        public virtual ICollection<ItemKit> Itens { get; set; }
        public virtual Loja Loja { get; set; }
    }
}