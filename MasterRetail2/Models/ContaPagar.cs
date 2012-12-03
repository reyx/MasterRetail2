using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ContaPagar
    {
        public int ContaPagarId { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Letra { get; set; }
        public Nullable<int> EntradaId { get; set; }
        public Nullable<int> FornecedorId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<System.DateTime> Emissao { get; set; }
        public Nullable<System.DateTime> Vencimento { get; set; }
        public Nullable<System.DateTime> Pagamento { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public Nullable<decimal> Juros { get; set; }
        public Nullable<decimal> ValorPago { get; set; }
        public Nullable<int> TipoDespesaId { get; set; }
        public string Historico { get; set; }
        public Nullable<int> TipoCobrancaId { get; set; }
        public Nullable<int> ContaCorrenteId { get; set; }
        public virtual ContaCorrente ContaCorrente { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual TipoCobranca TipoCobranca { get; set; }
        public virtual TipoDespesa TipoDespesa { get; set; }
    }
}