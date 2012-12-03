using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TipoRecebimento
    {
        public TipoRecebimento()
        {
            this.RecebimentosVenda = new List<RecebimentoVenda>();
            this.SubtiposRecebimento = new List<SubtipoRecebimento>();
        }

        public int TipoRecebimentoId { get; set; }
        public string Descricao { get; set; }
        public string DescricaoReduzida { get; set; }
        public Nullable<decimal> PontoSangria { get; set; }
        public string ImprimeCheque { get; set; }
        public string TipoTef { get; set; }
        public string TefId { get; set; }
        public string GeraRecebimento { get; set; }
        public Nullable<decimal> Reducao { get; set; }
        public string ViasTef { get; set; }
        public Nullable<int> RedeTefId { get; set; }
        public string Detalhe { get; set; }
        public Nullable<int> GrupoFechamento { get; set; }
        public Nullable<int> Icone { get; set; }
        public string Comportamento { get; set; }
        public virtual ICollection<RecebimentoVenda> RecebimentosVenda { get; set; }
        public virtual RedeTef RedeTef { get; set; }
        public virtual ICollection<SubtipoRecebimento> SubtiposRecebimento { get; set; }
    }
}