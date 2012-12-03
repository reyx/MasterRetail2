using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class TipoEndereco
    {
        public TipoEndereco()
        {
            this.EnderecosPessoa = new List<EnderecoPessoa>();
        }

        public int TipoEnderecoId { get; set; }
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
        public virtual ICollection<EnderecoPessoa> EnderecosPessoa { get; set; }
    }
}