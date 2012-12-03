using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Pdv
    {
        public Pdv()
        {
            this.Instrucoes = new List<InstrucaoPdv>();
            this.MicroTerminais = new List<MicroTerminal>();
            this.Movimentos = new List<MovimentoPdv>();
            this.Parametros = new List<ParametroPdv>();
            this.TecladosRapidos = new List<TecladoRapidoPdv>();
        }

        public int PdvId { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<int> LojaId { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> EcfId { get; set; }
        public Nullable<int> ListaId { get; set; }
        public Nullable<int> GrupoPdvId { get; set; }
        public virtual Ecf Ecf { get; set; }
        public virtual GrupoPdv Grupo { get; set; }
        public virtual ICollection<InstrucaoPdv> Instrucoes { get; set; }
        public virtual Lista Lista { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ICollection<MicroTerminal> MicroTerminais { get; set; }
        public virtual ICollection<MovimentoPdv> Movimentos { get; set; }
        public virtual ICollection<ParametroPdv> Parametros { get; set; }
        public virtual ICollection<TecladoRapidoPdv> TecladosRapidos { get; set; }
    }
}