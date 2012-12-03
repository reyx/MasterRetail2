using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class SubtipoRecebimento
    {
        public SubtipoRecebimento()
        {
            this.Parcelamentos = new List<ParcelamentoSubtipoRecebimento>();
            this.RecebimentosVenda = new List<RecebimentoVenda>();
        }

        public int SubtipoRecebimentoId { get; set; }
        public Nullable<int> TipoRecebimentoId { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> BandeiraId { get; set; }
        public virtual Bandeira Bandeira { get; set; }
        public virtual ICollection<ParcelamentoSubtipoRecebimento> Parcelamentos { get; set; }
        public virtual ICollection<RecebimentoVenda> RecebimentosVenda { get; set; }
        public virtual TipoRecebimento TipoRecebimento { get; set; }
    }
}