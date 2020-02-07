using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaDeDadosWeb.Models
{
    public class UsuarioConfirmacao
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public string Email { get; set; }
        public int Codigo { get; set; }
        public DateTime DtEnvio { get; set; }
        public DateTime DtConfirmacao { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
