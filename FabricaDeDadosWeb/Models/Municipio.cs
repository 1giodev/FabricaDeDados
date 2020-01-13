using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricaDeDadosWeb.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Endereco = new HashSet<Endereco>();
        }

        [Key]
        public int Id { get; set; }
        public int? IdEstado { get; set; }
        public int? CodigoIbge { get; set; }
        public string Nome { get; set; }
        
        [ForeignKey("IdEstado")]
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
