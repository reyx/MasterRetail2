using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Tabela
    {
        public int TabelaId { get; set; }
        public string Nome { get; set; }
        public string Dbf { get; set; }
        public string ClasseVo { get; set; }
        public string Descricao { get; set; }
        public string Chave { get; set; }
        public string TipoChave { get; set; }
        public Nullable<decimal> TamanhoChave { get; set; }
        public string ChaveMr { get; set; }
    }
}