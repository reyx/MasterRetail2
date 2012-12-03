using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class NaturezaOperacao
    {
        public int NaturezaOperacaoId { get; set; }
        public string Descricao { get; set; }
        public string CalculoIcms { get; set; }
        public string CalculoIpi { get; set; }
        public string CalculoSt { get; set; }
        public string Faturado { get; set; }
        public string Observacao { get; set; }
        public string Mensagem { get; set; }
        public string Operacao { get; set; }
        public Nullable<decimal> CalculoPis { get; set; }
        public Nullable<decimal> CalculoCofins { get; set; }
    }
}