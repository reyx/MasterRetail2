using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class GrupoTributacaoProduto
    {
        public GrupoTributacaoProduto()
        {
            this.Produtos = new List<Produto>();
        }

        public int GrupoTributacaoProdutoId { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> TributacaoOrigemId { get; set; }
        public Nullable<int> TributacaoIcmsId { get; set; }
        public Nullable<int> TributacaoIpiId { get; set; }
        public Nullable<int> TributacaoPisId { get; set; }
        public Nullable<int> TributacaoCofinsId { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual Tributacao TributacaoOrigem { get; set; }
        public virtual Tributacao TributacaoIcms { get; set; }
        public virtual Tributacao TributacaoIpi { get; set; }
        public virtual Tributacao TributacaoPis { get; set; }
        public virtual Tributacao TributacaoCofins { get; set; }
    }
}