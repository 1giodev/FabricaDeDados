using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaDeDadosWeb.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmacao { get; set; }
        public string Senha { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdSituacao { get; set; }

        [ForeignKey("IdSituacao")]
        public virtual UsuarioSituacao UsuarioSituacao { get; set; }
    }
}
