using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class FuncaoPerfil
	{
        public int FuncaoPerfilId { get; set; }
		public Nullable<int> PerfilId { get; set; }
		public Nullable<int> FuncaoProgramaId { get; set; }
		public string PermitidoString { get; set; }
        public bool Permitido
        {
            get { return PermitidoString == "A"; }
            set { PermitidoString = value ? "A" : "B"; }
        }
        public virtual Perfil Perfil { get; set; }
	}
}