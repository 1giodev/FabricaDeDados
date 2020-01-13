using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeDadosWeb.Models
{
    public partial class Regiao
    {
        public Regiao()
        {
            Estado = new HashSet<Estado>();
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual ICollection<Estado> Estado { get; set; }
    }
}
