using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class EmpresaEndereco
    {
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }

        public virtual Empresa IdEmpresaNavigation { get; set; }
        public virtual Endereco IdEnderecoNavigation { get; set; }
    }
}
