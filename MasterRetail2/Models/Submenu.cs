using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Submenu
    {
        public Submenu()
        {
            this.Grupos = new List<GrupoMenu>();
        }

        public int SubmenuId { get; set; }
        public Nullable<int> MenuId { get; set; }
        public Nullable<int> FuncaoProgramaId { get; set; }
        public string Item { get; set; }
        public Nullable<int> Ordem { get; set; }
        public virtual FuncaoPrograma FuncoesPrograma { get; set; }
        public virtual ICollection<GrupoMenu> Grupos { get; set; }
    }
}