using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class Regiao
    {
        public Regiao()
        {
            Estado = new HashSet<Estado>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Estado> Estado { get; set; }
    }
}
