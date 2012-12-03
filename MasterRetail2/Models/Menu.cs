using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Menu
    {
        public Menu()
        {
            this.FuncoesPrograma = new List<FuncaoPrograma>();
            this.Menus = new List<Menu>();
        }

        public int MenuId { get; set; }
        public string Item { get; set; }
        public Nullable<int> ParentId { get; set; }
        public virtual ICollection<FuncaoPrograma> FuncoesPrograma { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
        public virtual Menu Parent { get; set; }
    }
}