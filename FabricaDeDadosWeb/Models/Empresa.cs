using System;
using System.Collections.Generic;

namespace FabricaDeDadosWeb.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            EmpresaEndereco = new HashSet<EmpresaEndereco>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataAbertura { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<EmpresaEndereco> EmpresaEndereco { get; set; }
    }
}
