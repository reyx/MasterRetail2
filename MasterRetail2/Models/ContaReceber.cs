using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ContaReceber
    {
        public int ContaReceberId { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Letra { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> BandeiraId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> EntradaId { get; set; }
        public Nullable<System.DateTime> Emissao { get; set; }
        public Nullable<System.DateTime> Vencimento { get; set; }
        public Nullable<System.DateTime> Pagamento { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public Nullable<decimal> Juros { get; set; }
        public Nullable<decimal> ValorRecebido { get; set; }
        public string SituacaoEmissao { get; set; }
        public string Historico { get; set; }
        public Nullable<int> VendaId { get; set; }
        public Nullable<int> ContaCorrenteId { get; set; }
        public virtual Bandeira Bandeira { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ContaCorrente ContaCorrente { get; set; }
        public virtual Entrada Entrada { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Venda Venda { get; set; }
    }
}