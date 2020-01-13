using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricaDeDadosWeb.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Municipio = new HashSet<Municipio>();
        }

        [Key]
        public int Id { get; set; }
        public int IdRegiao { get; set; }
        public int CodigoIbge { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        [ForeignKey("IdRegiao")]
        public virtual Regiao Regiao { get; set; }
        public virtual ICollection<Municipio> Municipio { get; set; }
    }
}
