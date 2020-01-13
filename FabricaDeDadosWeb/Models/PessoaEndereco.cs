using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricaDeDadosWeb.Models
{
    public partial class PessoaEndereco
    {
        [Key]
        public int Id { get; set; }
        public int IdPessoa { get; set; }
        public int IdEndereco { get; set; }

        [ForeignKey("IdEndereco")]
        public virtual Endereco Endereco { get; set; }
        [ForeignKey("IdPessoa")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
