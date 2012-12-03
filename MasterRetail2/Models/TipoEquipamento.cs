using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class TipoEquipamento
    {
        public TipoEquipamento()
        {
            this.Equipamentos = new List<Equipamento>();
        }

        public int TipoEquipamentoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Equipamento> Equipamentos { get; set; }
    }
}