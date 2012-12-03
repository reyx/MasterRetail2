using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class LayoutBoleto
    {
        public int LayoutBoletoId { get; set; }
        public Nullable<int> BancoId { get; set; }
        public Nullable<int> ContaCorrenteId { get; set; }
        public Nullable<int> Linha { get; set; }
        public Nullable<int> Coluna { get; set; }
        public Nullable<int> TamanhoRetorno { get; set; }
        public Nullable<int> Vertical { get; set; }
        public Nullable<int> Horizontal { get; set; }
        public string TamanhoMilimetros { get; set; }
        public string TipoRetorno { get; set; }
        public string Campo { get; set; }
        public Nullable<int> SomaDias { get; set; }
        public Nullable<int> ExtInicial { get; set; }
        public Nullable<int> ExtFinal { get; set; }
        public string Texto { get; set; }
        public virtual Banco Banco { get; set; }
        public virtual ContaCorrente ContaCorrente { get; set; }
    }
}