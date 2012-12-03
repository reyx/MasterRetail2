using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class MovimentacaoEquipamento
    {
        public int MovimentacaoEquipamentoId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.DateTime> PrevisaoRetorno { get; set; }
        public Nullable<int> EquipamentoId { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> HistoricoEquipamentoId { get; set; }
        public string Documento { get; set; }
        public string Observacao { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Equipamento Equipamento { get; set; }
        public virtual HistoricoEquipamento HistoricoEquipamento { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
    }
}