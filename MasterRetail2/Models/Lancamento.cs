using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Lancamento
    {
        public int LancamentoId { get; set; }
        public Nullable<int> ContaCorrenteId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> HistoricoLancamentoId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> TipoDespesaId { get; set; }
        public string Documento { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public string Operacao { get; set; }
        public Nullable<decimal> SaldoAnterior { get; set; }
        public Nullable<decimal> SaldoAtual { get; set; }
        public string Observacao { get; set; }
        public Nullable<int> LojaId { get; set; }
        public virtual ContaCorrente ContaCorrente { get; set; }
        public virtual HistoricoLancamento HistoricoLancamento { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual TipoDespesa TipoDespesa { get; set; }
    }
}