using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class PessoaEndereco
    {
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
