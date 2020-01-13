using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace FabricaDeDadosWeb.Models
{
    public partial class GioDevDadosContext : DbContext
    {
        public GioDevDadosContext()
        {
        }

        public GioDevDadosContext(DbContextOptions<GioDevDadosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresaEndereco> EmpresaEndereco { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<PessoaEndereco> PessoaEndereco { get; set; }
        public virtual DbSet<Regiao> Regiao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot ConfiguracaoApp = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ConfiguracaoApp.GetSection("ConnectionStrings:GioDevDadosContext").Value);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Empresa_seq\"'::regclass)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.Cnpj)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.DataAbertura).HasColumnType("date");

                entity.Property(e => e.DataCadastro).HasColumnType("timestamp(4) without time zone");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.InscricaoEstadual)
                    .IsRequired()
                    .HasMaxLength(14);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.WebSite)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<EmpresaEndereco>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.EmpresaEndereco)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EmpresaEndereco_IdEmpresa_fkey");

                entity.HasOne(d => d.IdEnderecoNavigation)
                    .WithMany(p => p.EmpresaEndereco)
                    .HasForeignKey(d => d.IdEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EmpresaEndereco_IdEndereco_fkey");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Endereco_seq\"'::regclass)");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.IdMunicipio).HasDefaultValueSql("1");

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Municipio)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Uf)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Endereco_Municipio");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Estado_seq\"'::regclass)");

                entity.Property(e => e.CodigoIbge).HasColumnName("CodigoIBGE");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("1");

                entity.HasOne(d => d.IdRegiaoNavigation)
                    .WithMany(p => p.Estado)
                    .HasForeignKey(d => d.IdRegiao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estado_Regiao");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.Property(e => e.CodigoIbge).HasColumnName("CodigoIBGE");

                entity.Property(e => e.Nome).HasMaxLength(250);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Municipio)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_Municipio_Estado");
            });

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("nextval('\"Pessoa_seq\"'::regclass)");

                entity.Property(e => e.Celular)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11);

                entity.Property(e => e.DataCadastro).HasColumnType("timestamp(4) without time zone");

                entity.Property(e => e.DataNascimento).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NomeMae)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NomePai)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Rg)
                    .IsRequired()
                    .HasMaxLength(13);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Telefone)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            modelBuilder.Entity<PessoaEndereco>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdEnderecoNavigation)
                    .WithMany(p => p.PessoaEndereco)
                    .HasForeignKey(d => d.IdEndereco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PessoaEndereco_IdEndereco_fkey");

                entity.HasOne(d => d.IdPessoaNavigation)
                    .WithMany(p => p.PessoaEndereco)
                    .HasForeignKey(d => d.IdPessoa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PessoaEndereco_IdPessoa_fkey");
            });

            modelBuilder.Entity<Regiao>(entity =>
            {
                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Sigla)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.HasSequence("Empresa_seq");

            modelBuilder.HasSequence("Endereco_seq");

            modelBuilder.HasSequence("Estado_seq");

            modelBuilder.HasSequence("Pessoa_seq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
