using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Volume
    {
        public Volume()
        {
            this.Lacres = new List<Lacre>();
            this.Entradas = new List<VolumeEntrada>();
            this.Vendas = new List<VolumeVenda>();
        }

        public int VolumeId { get; set; }
        public Nullable<decimal> Quantidade { get; set; }
        public string Especie { get; set; }
        public string Marca { get; set; }
        public string Numeracao { get; set; }
        public Nullable<decimal> PesoLiquido { get; set; }
        public Nullable<decimal> PesoBruto { get; set; }
        public virtual ICollection<Lacre> Lacres { get; set; }
        public virtual ICollection<VolumeEntrada> Entradas { get; set; }
        public virtual ICollection<VolumeVenda> Vendas { get; set; }
    }
}