using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class RedeTef
    {
        public RedeTef()
        {
            this.TiposRecebimento = new List<TipoRecebimento>();
        }

        public int RedeTefId { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Nome { get; set; }
        public string ArquivoTmp { get; set; }
        public string ArquivoReq { get; set; }
        public string ArquivoSta { get; set; }
        public string ArquivoRes { get; set; }
        public string ArquivoExe { get; set; }
        public Nullable<int> Tentativas { get; set; }
        public Nullable<int> ToTef { get; set; }
        public Nullable<int> ToTrs { get; set; }
        public Nullable<int> ViasTef { get; set; }
        public Nullable<int> ViasAdm { get; set; }
        public string TipoCnf { get; set; }
        public Nullable<decimal> Mtpl { get; set; }
        public Nullable<decimal> MtplEnv { get; set; }
        public string MascVal { get; set; }
        public string MensagemInat { get; set; }
        public string MensagemNcn { get; set; }
        public string MensagemCnc { get; set; }
        public string MensagemNc2 { get; set; }
        public string AutoFinal { get; set; }
        public string AutoCanc { get; set; }
        public string Atv { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual ICollection<TipoRecebimento> TiposRecebimento { get; set; }
    }
}