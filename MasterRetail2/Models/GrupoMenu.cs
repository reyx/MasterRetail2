using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class GrupoMenu
    {
        public int GrupoMenuId { get; set; }
        public Nullable<int> SubmenuId { get; set; }
        public string Item { get; set; }
        public Nullable<int> Ordem { get; set; }
        public string Icone { get; set; }
        public virtual Submenu Submenu { get; set; }
    }
}