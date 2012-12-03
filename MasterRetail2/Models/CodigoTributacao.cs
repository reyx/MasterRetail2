using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class CodigoTributacao
    {
        public CodigoTributacao()
        {
            this.CodigosTributacaoEcf = new List<CodigoTributacaoEcf>();
            this.Produtos = new List<Produto>();
            this.ProdutosLoja = new List<ProdutoLoja>();
        }

        public int CodigoTributacaoId { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> AliquotaIcms { get; set; }
        public virtual ICollection<CodigoTributacaoEcf> CodigosTributacaoEcf { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<ProdutoLoja> ProdutosLoja { get; set; }
    }
}