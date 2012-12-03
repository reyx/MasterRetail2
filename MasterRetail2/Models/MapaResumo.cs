using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class MapaResumo
    {
        public MapaResumo()
        {
            this.ValoresMapaResumo = new List<ValorMapaResumo>();
        }

        public int MapaResumoId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> EcfId { get; set; }
        public Nullable<int> ContadorOperacoes { get; set; }
        public Nullable<decimal> GrandeTotalInicial { get; set; }
        public Nullable<decimal> GrandeTotalFinal { get; set; }
        public Nullable<decimal> MovimentosDia { get; set; }
        public Nullable<decimal> CancelamentosDia { get; set; }
        public Nullable<decimal> DescontosDia { get; set; }
        public Nullable<decimal> Liquido { get; set; }
        public Nullable<int> ContadorReducoes { get; set; }
        public Nullable<decimal> SubstituicoesTributarias { get; set; }
        public Nullable<decimal> Isentos { get; set; }
        public Nullable<decimal> NaoTributados { get; set; }
        public Nullable<int> Controle { get; set; }
        public Nullable<int> ControleOperacaoFinal { get; set; }
        public virtual Ecf Ecf { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ICollection<ValorMapaResumo> ValoresMapaResumo { get; set; }
    }
}