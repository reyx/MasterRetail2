using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Mensagem
    {
        public int MensagemId { get; set; }
        public string Tela { get; set; }
        public Nullable<int> QuantidadeExibicoes { get; set; }
        public Nullable<int> Intervalo { get; set; }
        public Nullable<System.DateTime> DataInicial { get; set; }
        public Nullable<System.DateTime> DataFinal { get; set; }
        public string Fechar { get; set; }
        public Nullable<int> Tempo { get; set; }
        public string Emitente { get; set; }
        public string Texto { get; set; }
        public string Pesquisa { get; set; }
        public Nullable<int> MinimoRespostas { get; set; }
        public Nullable<int> MaximoRespostas { get; set; }
        public string Opcoes { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> ValorGrupoId { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ValorGrupo ValoresGrupo { get; set; }
    }
}