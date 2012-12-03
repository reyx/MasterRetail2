using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Entities
{
    public class ValorGrupo
    {
        public ValorGrupo()
        {
            this.Mensagens = new List<Mensagem>();
            this.Operadores = new List<OperadorValorGrupo>();
            this.Lojas = new List<ValorGrupoLoja>();
        }

        public int ValorGrupoId { get; set; }
        public Nullable<int> TipoGrupoId { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Mensagem> Mensagens { get; set; }
        public virtual ICollection<OperadorValorGrupo> Operadores { get; set; }
        public virtual TipoGrupo TipoGrupo { get; set; }
        public virtual ICollection<ValorGrupoLoja> Lojas { get; set; }
    }
}