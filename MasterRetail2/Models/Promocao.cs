using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Promocao
    {
        public Promocao()
        {
            this.Itens = new List<ItemPromocao>();
            this.ItensTeclado = new List<ItemTecladoRapido>();
            this.Produtos = new List<Produto>();
            this.ProdutosLoja = new List<ProdutoLoja>();
        }

        public int PromocaoId { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public virtual ICollection<ItemPromocao> Itens { get; set; }
        public virtual ICollection<ItemTecladoRapido> ItensTeclado { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<ProdutoLoja> ProdutosLoja { get; set; }
    }
}