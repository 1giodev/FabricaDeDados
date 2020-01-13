using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class PessoaEndereco
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdEndereco { get; set; }

        public virtual Endereco IdEnderecoNavigation { get; set; }
        public virtual Pessoa IdPessoaNavigation { get; set; }
    }
}
