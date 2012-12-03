using System;
using System.Collections.Generic;

namespace Rcky.MasterRetail2.Models
{
	public class Pessoa
	{
	    public Pessoa()
		{
			this.Bandeiras = new List<Bandeira>();
			this.Clientes = new List<Cliente>();
			this.Consultores = new List<Consultor>();
			this.DocumentosPessoa = new List<DocumentoPessoa>();
			this.Emails = new List<Email>();
			this.EnderecosPessoa = new List<EnderecoPessoa>();
			this.Entregadores = new List<Entregador>();
			this.Fones = new List<Fone>();
			this.Fornecedores = new List<Fornecedor>();
			this.Lojas = new List<Loja>();
			this.Operadores = new List<Operador>();
			this.PessoasRelacionamentoA = new List<PessoaRelacionamento>();
			this.PessoasRelacionamentoB = new List<PessoaRelacionamento>();
			this.Vendedores = new List<Vendedor>();
			this.Transportadores = new List<Transportador>();
			this.Telefones = new List<Telefone>();
		}

		public int PessoaId { get; set; }
		public Nullable<int> LojaId { get; set; }
		public string Nome { get; set; }
		public string Tipo{ get; set; }
		public string Observacao{ get; set; }
		public string Fantasia { get; set; }
		public Nullable<int> DocumentoId { get; set; }
		public Nullable<System.DateTime> Nascimento{ get; set; }
		public string Aniversario { get; set; }
		public Nullable<System.DateTime> Cadastro{ get; set; }
		public string Natureza { get; set; }
		public string Senha { get; set; }
		public byte[] Foto{ get; set; }
		public string SenhaPdv{ get; set; }
		public virtual ICollection<Bandeira> Bandeiras{ get; set; }
		public virtual ICollection<Cliente> Clientes { get; set; }
		public virtual ICollection<Consultor> Consultores { get; set; }
		public virtual ICollection<DocumentoPessoa> DocumentosPessoa { get; set; }
		public virtual ICollection<Email> Emails { get; set; }
		public virtual ICollection<EnderecoPessoa> EnderecosPessoa { get; set; }
		public virtual ICollection<Entregador> Entregadores { get; set; }
		public virtual ICollection<Fone> Fones { get; set; }
		public virtual ICollection<Fornecedor> Fornecedores { get; set; }
		public virtual Loja Loja { get; set; }
		public virtual ICollection<Loja> Lojas { get; set; }
		public virtual ICollection<Operador> Operadores { get; set; }
		public virtual ICollection<PessoaRelacionamento> PessoasRelacionamentoA  { get; set; }
		public virtual ICollection<PessoaRelacionamento> PessoasRelacionamentoB { get; set; }
		public virtual ICollection<Vendedor> Vendedores { get; set; }
		public virtual ICollection<Transportador> Transportadores { get; set; }
		public virtual ICollection<Telefone> Telefones { get; set; }
	}
}

