using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class FuncaoPrograma
	{
        public FuncaoPrograma()
		{
            this.ItensManual = new List<ItemManual>();
            this.Submenus = new List<Submenu>();
		}

        public int FuncaoProgramaId { get; set; }
		public string Codigo { get; set; }
		public string Descricao { get; set; }
		public Nullable<int> ProgrmaId{ get; set; }
		public string Url { get; set; }
		public Nullable<int> Ordem{ get; set; }
		public Nullable<int> MenuId { get; set; }
		public string GeraLogString { get; set; }
        public bool GeraLog
        {
            get { return GeraLogString == "A"; }
            set { GeraLogString = value ? "A" : "B"; }
        }
		public virtual ICollection<ItemManual> ItensManual{ get; set; }
		public virtual ICollection<Submenu> Submenus{ get; set; }
		public virtual Menu Menu { get; set; }
        public virtual Programa Programa { get; set; }
	}
}