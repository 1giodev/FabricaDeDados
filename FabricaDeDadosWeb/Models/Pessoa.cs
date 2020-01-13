using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            PessoaEndereco = new HashSet<PessoaEndereco>();
        }

        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<PessoaEndereco> PessoaEndereco { get; set; }
    }
}
