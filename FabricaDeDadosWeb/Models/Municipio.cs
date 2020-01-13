using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Endereco = new HashSet<Endereco>();
        }

        public int Id { get; set; }
        public int? IdEstado { get; set; }
        public int? CodigoIbge { get; set; }
        public string Nome { get; set; }

        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
