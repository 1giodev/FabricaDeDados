using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FabricaDeDadosWeb.Models
{
    public class UsuarioLogin
    {
        public int Id { get; set; }
        public string IdUsuario { get; set; }
        public string IpLogin { get; set; }
        public DateTime DtLogin { get; set; }


        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
