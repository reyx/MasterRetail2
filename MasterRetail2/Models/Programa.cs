using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Programa
    {
        public Programa()
        {
            this.Funcoes = new List<FuncaoPrograma>();
        }

        public int ProgramaId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<FuncaoPrograma> Funcoes { get; set; }
    }
}