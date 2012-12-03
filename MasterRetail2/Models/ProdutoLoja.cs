using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ProdutoLoja
    {
        public int ProdutoLojaId { get; set; }
        public int ProdutoId { get; set; }
        public int LojaId { get; set; }
        public string PesoCaixa { get; set; }
        public Nullable<int> Etiqueta { get; set; }
        public Nullable<decimal> CoeficienteRoyalties { get; set; }
        public string TipoVenda { get; set; }
        public string TipoBaixa { get; set; }
        public string TipoEntrada { get; set; }
        public Nullable<decimal> EstoqueMinimo { get; set; }
        public Nullable<decimal> EstoqueMaximo { get; set; }
        public string Local { get; set; }
        public Nullable<int> CodigoTributacaoId { get; set; }
        public Nullable<int> PromocaoId { get; set; }
        public string Cst { get; set; }
        public Nullable<decimal> Ipi { get; set; }
        public Nullable<decimal> Icms { get; set; }
        public Nullable<decimal> Reducao { get; set; }
        public Nullable<decimal> St { get; set; }
        public Nullable<decimal> IpiPeso { get; set; }
        public string Cf { get; set; }
        public string Impressora { get; set; }
        public virtual CodigoTributacao CodigosTributacao { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Promocao Promocao { get; set; }
    }
}