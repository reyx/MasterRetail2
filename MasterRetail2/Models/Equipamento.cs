using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Equipamento
    {
        public Equipamento()
        {
            this.Produtos = new List<EquipamentoProduto>();
            this.MovimentacoesEquipamento = new List<MovimentacaoEquipamento>();
        }

        public int EquipamentoId { get; set; }
        public Nullable<int> TipoEquipamentoId { get; set; }
        public string Serie { get; set; }
        public string SerieObrigatoria { get; set; }
        public Nullable<int> DiasDevolucaoPadrao { get; set; }
        public string Descricao { get; set; }
        public string CodigoBarras { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<EquipamentoProduto> Produtos { get; set; }
        public virtual ICollection<MovimentacaoEquipamento> MovimentacoesEquipamento { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual TipoEquipamento TipoEquipamento { get; set; }
    }
}