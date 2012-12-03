using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class EquipamentoProduto
    {
        public int EquipamentoProdutoId { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<int> EquipamentoId { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public virtual Equipamento Equipamento { get; set; }
        public virtual Produto Produto { get; set; }
    }
}