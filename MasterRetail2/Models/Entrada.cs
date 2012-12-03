using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
    public class Entrada
    {
        public Entrada()
        {
            this.ContasPagar = new List<ContaPagar>();
            this.ContasReceber = new List<ContaReceber>();
            this.ItensEntrada = new List<ItemEntrada>();
            this.NotasFiscais = new List<NotaFiscal>();
            this.Volumes = new List<VolumeEntrada>();
        }

        public int EntradaId { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<int> LojaId { get; set; }
        public Nullable<int> FornecedorId { get; set; }
        public Nullable<int> CFOP_NTOP { get; set; }
        public Nullable<int> CFOP_NTOP_TRAN_ENTR { get; set; }
        public Nullable<int> OperadorId { get; set; }
        public Nullable<int> VendaId { get; set; }
        public Nullable<int> CondicaoPagamentoId { get; set; }
        public Nullable<int> VendedorId { get; set; }
        public Nullable<int> TransportadorId { get; set; }
        public Nullable<int> VeiculoId { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.DateTime> Emissao { get; set; }
        public string Condicional { get; set; }
        public Nullable<decimal> BaseIcms { get; set; }
        public Nullable<decimal> Icms { get; set; }
        public Nullable<decimal> BaseIcmsSt { get; set; }
        public Nullable<decimal> IcmsSt { get; set; }
        public Nullable<decimal> Ipi { get; set; }
        public Nullable<decimal> IpiSt { get; set; }
        public Nullable<decimal> Pis { get; set; }
        public Nullable<decimal> PisSt { get; set; }
        public Nullable<decimal> Cofins { get; set; }
        public Nullable<decimal> CofinsSt { get; set; }
        public Nullable<decimal> ValorMercadoria { get; set; }
        public Nullable<decimal> Frete { get; set; }
        public Nullable<decimal> Seguro { get; set; }
        public Nullable<decimal> Desconto { get; set; }
        public Nullable<decimal> DespesaAcessoria { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public string Observacao { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public Nullable<int> EnderecoFornecedorId { get; set; }
        public Nullable<int> EnderecoEntregaId { get; set; }
        public Nullable<int> EnderecoLojaId { get; set; }
        public Nullable<int> EnderecoRetiradaId { get; set; }
        public Nullable<int> EnderecoTransportadorId { get; set; }
        public Nullable<decimal> ImpostoImportacao { get; set; }
        public Nullable<decimal> BaseIrrf { get; set; }
        public Nullable<decimal> Irrf { get; set; }
        public Nullable<decimal> BasePrevidencia { get; set; }
        public Nullable<decimal> Previdencia { get; set; }
        public Nullable<decimal> RestituicaoIpi { get; set; }
        public Nullable<decimal> RestituicaoPis { get; set; }
        public Nullable<decimal> RestituicaoCofins { get; set; }
        public Nullable<decimal> RestituicaoCsll { get; set; }
        public string ModalidadeFrete { get; set; }
        public Nullable<decimal> BaseIcmsTransportador { get; set; }
        public Nullable<decimal> AliquotaIcmsTransportador { get; set; }
        public Nullable<decimal> IcmsTransportador { get; set; }
        public Nullable<decimal> ValorTransportador { get; set; }
        public Nullable<decimal> PesoLiquido { get; set; }
        public Nullable<decimal> PesoBruto { get; set; }
        public virtual CondicaoPagamento CondicaoPagamento { get; set; }
        public virtual ICollection<ContaPagar> ContasPagar { get; set; }
        public virtual ICollection<ContaReceber> ContasReceber { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA1 { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA2 { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA3 { get; set; }
        public virtual EnderecoPessoa ENDERECOS_PESSOA4 { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual ICollection<ItemEntrada> ItensEntrada { get; set; }
        public virtual ICollection<NotaFiscal> NotasFiscais { get; set; }
        public virtual ICollection<VolumeEntrada> Volumes { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Loja Loja { get; set; }
        public virtual Operador Operador { get; set; }
        public virtual Transportador Transportador { get; set; }
        public virtual Veiculo Veiculo { get; set; }
        public virtual Vendedor Vendedor { get; set; }
    }
}