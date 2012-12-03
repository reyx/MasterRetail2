using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Inventario
	{
        public Inventario()
		{
            this.Itens = new List<ItemInventario>();
		}

        public int InventarioId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<System.DateTime> Inicio { get; set; }
		public Nullable<System.DateTime> Fim { get; set; }
		public Nullable<decimal> ValorEstoque { get; set; }
		public Nullable<decimal> ValorInventario { get; set; }
		public Nullable<int> OperadorId { get; set; }
		public Nullable<int> LocalEstoqueId { get; set; }
		public virtual LocalEstoque LocalEstoque { get; set; }
		public virtual Loja Loja { get; set; }
        public virtual ICollection<ItemInventario> Itens { get; set; }
		public virtual Operador Operador { get; set; }
	}
}