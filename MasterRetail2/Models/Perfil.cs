using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class Perfil
    {
        public Perfil()
        {
            this.Funcoes = new List<FuncaoPerfil>();
            this.Operadores = new List<Operador>();
        }

        public int PerfilId { get; set; }
        public string Descricao { get; set; }
        public Nullable<int> Nivel { get; set; }
        public virtual ICollection<FuncaoPerfil> Funcoes { get; set; }
        public virtual ICollection<Operador> Operadores { get; set; }
    }
}