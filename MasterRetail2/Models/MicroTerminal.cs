using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
	public class MicroTerminal
	{
        public MicroTerminal()
		{
            this.TeclasMicroTerminal = new List<TeclaMicroTerminal>();
		}

        public int MicroTerminalId { get; set; }
		public Nullable<int> NUMERO_MTER { get; set; }
		public Nullable<int> LojaId { get; set; }
		public Nullable<int> PdvId { get; set; }
		public string DESC_MTER { get; set; }
		public string TIPO_MTER { get; set; }
		public Nullable<int> TIMEOUT_MTER { get; set; }
		public string NOVACOM_MTER { get; set; }
		public string TIPOCON_MTER { get; set; }
		public Nullable<int> TECLACOM_MTER { get; set; }
		public Nullable<int> TECLACLI_MTER { get; set; }
		public Nullable<int> TECLAVEND_MTER { get; set; }
		public Nullable<int> TECLABAL_MTER { get; set; }
		public Nullable<int> TECLAPROD_MTER { get; set; }
		public Nullable<int> TECLAMULT_MTER { get; set; }
		public Nullable<int> TECLAPRECO_MTER { get; set; }
		public Nullable<int> TECLAFEC_MTER { get; set; }
		public Nullable<int> TECLAFCP_MTER { get; set; }
		public Nullable<int> TECLACNS_MTER { get; set; }
		public Nullable<int> TECLASIM_MTER { get; set; }
		public Nullable<int> TECLANAO_MTER { get; set; }
		public Nullable<int> ListaId { get; set; }
		public Nullable<int> COMINI_MTER { get; set; }
		public Nullable<int> COMFIN_MTER { get; set; }
		public Nullable<int> TOSERIAL_MTER { get; set; }
		public Nullable<int> BALTMRET_MTER { get; set; }
		public Nullable<int> BALINI_MTER { get; set; }
		public Nullable<int> BALTAM_MTER { get; set; }
		public Nullable<int> BALDIV_MTER { get; set; }
		public string BALCNF_MTER { get; set; }
		public string TORRE_MTER { get; set; }
		public string ENDIP_MTER { get; set; }
		public virtual Lista Lista { get; set; }
		public virtual Loja Loja { get; set; }
        public virtual ICollection<TeclaMicroTerminal> TeclasMicroTerminal { get; set; }
        public virtual Pdv Pdv { get; set; }
	}
}