using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class FotoProduto
    {
        public int FotoProdutoId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public string Descricao { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<bool> Principal { get; set; }
        public virtual Produto Produto { get; set; }
    }
}