using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ItemTecladoRapido
    {
        public int ItemTecladoRapidoId { get; set; }
        public Nullable<int> TecladoRapidoId { get; set; }
        public Nullable<int> Tecla { get; set; }
        public string Tipo { get; set; }
        public Nullable<int> ProdutoId { get; set; }
        public Nullable<int> PromocaoId { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public string Descricao { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Promocao Promocao { get; set; }
        public virtual TecladoRapido TecladoRapido { get; set; }
    }
}