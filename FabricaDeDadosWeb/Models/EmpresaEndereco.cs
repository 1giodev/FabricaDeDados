using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricaDeDadosWeb.Models
{
    public partial class EmpresaEndereco
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }
        [ForeignKey("IdEndereco")]
        public virtual Endereco Endereco { get; set; }
    }
}
