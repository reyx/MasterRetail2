using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ContaCorrente
    {
        public ContaCorrente()
        {
            this.ContasCorrentesLojas = new List<ContaCorrenteLoja>();
            this.ContasPagar = new List<ContaPagar>();
            this.ContasReceber = new List<ContaReceber>();
            this.Lancamentos = new List<Lancamento>();
            this.LayoutsBoletos = new List<LayoutBoleto>();
            this.LayoutsCnab = new List<LayoutCnab>();
        }

        public int ContaCorrenteId { get; set; }
        public Nullable<int> AgenciaId { get; set; }
        public string Conta { get; set; }
        public string Nome { get; set; }
        public Nullable<decimal> SaldoAtual { get; set; }
        public Nullable<int> Cnab { get; set; }
        public virtual Agencia Agencia { get; set; }
        public virtual ICollection<ContaCorrenteLoja> ContasCorrentesLojas { get; set; }
        public virtual ICollection<ContaPagar> ContasPagar { get; set; }
        public virtual ICollection<ContaReceber> ContasReceber { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        public virtual ICollection<LayoutBoleto> LayoutsBoletos { get; set; }
        public virtual ICollection<LayoutCnab> LayoutsCnab { get; set; }
    }
}