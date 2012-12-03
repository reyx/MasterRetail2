using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rcky.MasterRetail2.Models
{
    public class ArquivoRecebido
    {
        public int ArquivoRecebidoId { get; set; }
        public string Nome { get; set; }
        public string Situacao { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Ip { get; set; }
        public string Observacao { get; set; }
        public string InformacaoAdicional { get; set; }
        public string QuantidadeOcorrencias { get; set; }
        public string SucessoString { get; set; }
        public bool Sucesso
        {
            get { return SucessoString == "A"; }
            set { SucessoString = value ? "A" : "B"; }
        }
        public string Versao { get; set; }
        public virtual Loja Loja { get; set; }
    }
}