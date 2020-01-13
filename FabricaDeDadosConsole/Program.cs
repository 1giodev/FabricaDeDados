using FabricaDeDadosWeb.Models;
using System;
using System.IO;

namespace FabricaDeDadosConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Contexto = new FabricaDeDadosWeb.Models.GioDevDadosContext();

            CadastrarPessoaEndereco();
            CadastrarEmpresaEndereco();
        }

        public static void CadastrarPessoaEndereco()
        {
            String[] ArquivoPessoaEndereco = System.IO.File.ReadAllLines(@"D:\PessoaEndereco.csv");

            StreamWriter InsertEnderecosPessoas = new StreamWriter("D:\\EnderecoDePessoas.txt")
            {
                AutoFlush = true
            };

            foreach (var EnderecoPessoa in ArquivoPessoaEndereco)
            {
                String[] CodigosEnderecoPessoa = EnderecoPessoa.Split(',');

                String InsertString = "INSERT INTO public.\"PessoaEndereco\"(\"IdPessoa\", \"IdEndereco\") VALUES (" + CodigosEnderecoPessoa[0] + "," + CodigosEnderecoPessoa[1] + "\");";
                InsertEnderecosPessoas.WriteLine(InsertString);
            }

            InsertEnderecosPessoas.Close();
        }

        public static void CadastrarEmpresaEndereco()
        {
            String[] ArquivoEmpresaEndereco = System.IO.File.ReadAllLines(@"D:\EmpresaEndereco.csv");

            StreamWriter InsertEnderecosEmpresas = new StreamWriter("D:\\EnderecoDeEmpresas.txt")
            {
                AutoFlush = true
            };

            foreach (var EnderecoEmpresa in ArquivoEmpresaEndereco)
            {
                String[] CodigosEnderecoEmpresa = EnderecoEmpresa.Split(',');

                String InsertString = "INSERT INTO public.\"EmpresaEndereco\"(\"IdEmpresa\", \"IdEndereco\") VALUES (" + CodigosEnderecoEmpresa[0] + "," + CodigosEnderecoEmpresa[1] + "\");";
                InsertEnderecosEmpresas.WriteLine(InsertString);
            }

            InsertEnderecosEmpresas.Close();
        }
    }
}
