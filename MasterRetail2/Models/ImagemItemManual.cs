using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class ImagemItemManual
	{
        public int ImagemItemManualId { get; set; }
		public Nullable<int> ItemManualId { get; set; }
		public string Descricao { get; set; }
        public virtual ItemManual ItemManual { get; set; }
	}
}