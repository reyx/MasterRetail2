using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class InutilizacaoNfe
    {
        public int InutilizacaoNfeId { get; set; }
        public string Ambiente { get; set; }
        public string SiglaUf { get; set; }
        public string Ano { get; set; }
        public string Cnpj { get; set; }
        public Nullable<int> Modelo { get; set; }
        public Nullable<int> Serie { get; set; }
        public string NumeroInicial { get; set; }
        public string NumeroFinal { get; set; }
        public string Justificativa { get; set; }
        public Nullable<int> LojaId { get; set; }
    }
}