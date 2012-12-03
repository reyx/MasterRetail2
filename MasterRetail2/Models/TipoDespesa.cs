using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class TipoDespesa
    {
        public TipoDespesa()
        {
            this.ContasPagar = new List<ContaPagar>();
            this.DespesasBase = new List<DespesaBase>();
            this.Lancamentos = new List<Lancamento>();
            this.OcorrenciasPdv = new List<OcorrenciaPdv>();
        }

        public int TipoDespesaId { get; set; }
        public Nullable<int> GrupoDespesaId { get; set; }
        public string Descricao { get; set; }
        public string HistoricoObrigatorioString { get; set; }
        public bool HistoricoObrigatorio
        {
            get { return HistoricoObrigatorioString == "A"; }
            set { HistoricoObrigatorioString = value ? "A" : "B"; }
        }
        public string PadraoZeroString { get; set; }
        public bool PadraoZero
        {
            get { return PadraoZeroString == "A"; }
            set { PadraoZeroString = value ? "A" : "B"; }
        }
        public Nullable<decimal> Margem { get; set; }
        public Nullable<decimal> ValorPadrao { get; set; }
        public virtual ICollection<ContaPagar> ContasPagar { get; set; }
        public virtual ICollection<DespesaBase> DespesasBase { get; set; }
        public virtual GrupoDespesa GrupoDespesa { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<OcorrenciaPdv> OcorrenciasPdv { get; set; }
    }
}