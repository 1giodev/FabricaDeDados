using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Municipio = new HashSet<Municipio>();
        }

        public int Id { get; set; }
        public int IdRegiao { get; set; }
        public int CodigoIbge { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public virtual Regiao IdRegiaoNavigation { get; set; }
        public virtual ICollection<Municipio> Municipio { get; set; }
    }
}
