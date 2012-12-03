using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class Tributacao
	{
        public Tributacao()
		{
            this.GruposTributacaoProdutoCofins = new List<GrupoTributacaoProduto>();
            this.GruposTributacaoProdutoIcms = new List<GrupoTributacaoProduto>();
            this.GruposTributacaoProdutoIpi = new List<GrupoTributacaoProduto>();
            this.GruposTributacaoProdutoOrigem = new List<GrupoTributacaoProduto>();
            this.GruposTributacaoProdutoPis = new List<GrupoTributacaoProduto>();
		}

        public int TributacaoId { get; set; }
		public string Codigo { get; set; }
		public string Tipo { get; set; }
		public string Descricao{ get; set; }
		public string Observacao { get; set; }
        public virtual ICollection<GrupoTributacaoProduto> GruposTributacaoProdutoCofins { get; set; }
        public virtual ICollection<GrupoTributacaoProduto> GruposTributacaoProdutoIcms { get; set; }
        public virtual ICollection<GrupoTributacaoProduto> GruposTributacaoProdutoIpi { get; set; }
        public virtual ICollection<GrupoTributacaoProduto> GruposTributacaoProdutoOrigem { get; set; }
        public virtual ICollection<GrupoTributacaoProduto> GruposTributacaoProdutoPis { get; set; }
	}
}