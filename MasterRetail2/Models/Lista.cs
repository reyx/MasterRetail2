using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Lista
    {
        public Lista()
        {
            this.Clientes = new List<Cliente>();
            this.EvolucoesCusto = new List<EvolucaoCusto>();
            this.Lojas = new List<Loja>();
            this.ListasLoja = new List<ListaLoja>();
            this.MicroTerminais = new List<MicroTerminal>();
            this.ProdutosLista = new List<ProdutoLista>();
            this.Pdvs = new List<Pdv>();
        }

        public int ListaId { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> InicioValidade { get; set; }
        public Nullable<System.DateTime> TerminoValidade { get; set; }
        public string Preco { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<EvolucaoCusto> EvolucoesCusto { get; set; }
        public virtual ICollection<Loja> Lojas { get; set; }
        public virtual ICollection<ListaLoja> ListasLoja { get; set; }
        public virtual ICollection<MicroTerminal> MicroTerminais { get; set; }
        public virtual ICollection<ProdutoLista> ProdutosLista { get; set; }
        public virtual ICollection<Pdv> Pdvs { get; set; }
    }
}