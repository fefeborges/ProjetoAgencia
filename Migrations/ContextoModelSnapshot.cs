﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoAgencia.Models;

#nullable disable

namespace ProjetoAgencia.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoAgencia.Models.Atracoes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdAtracoes");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeAtracoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeAtracoes");

                    b.HasKey("Id");

                    b.ToTable("Atracoes");
                });

            modelBuilder.Entity("ProjetoAgencia.Models.Cadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCadastro");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AtracoesId")
                        .HasColumnType("int");

                    b.Property<int>("DestinoId")
                        .HasColumnType("int");

                    b.Property<int>("EstadiaId")
                        .HasColumnType("int");

                    b.Property<int>("NomeContato")
                        .HasColumnType("int")
                        .HasColumnName("NomeContato");

                    b.Property<string>("NomePessoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomePessoa");

                    b.Property<int>("PassageirosId")
                        .HasColumnType("int");

                    b.Property<int>("TransporteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtracoesId");

                    b.HasIndex("DestinoId");

                    b.HasIndex("EstadiaId");

                    b.HasIndex("PassageirosId");

                    b.HasIndex("TransporteId");

                    b.ToTable("Cadastro");
                });

            modelBuilder.Entity("ProjetoAgencia.Models.Destino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDestino");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeDestino")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeDestino");

                    b.HasKey("Id");

                    b.ToTable("Destino");
                });

            modelBuilder.Entity("ProjetoAgencia.Models.Estadia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdEstadia");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NomeEstadia")
                        .HasColumnType("int")
                        .HasColumnName("NomeEstadia");

                    b.HasKey("Id");

                    b.ToTable("Estadia");
                });

            modelBuilder.Entity("ProjetoAgencia.Models.Passageiros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdPassageiros");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NomePassageiros")
                        .HasColumnType("int")
                        .HasColumnName("NomePassageiros");

                    b.HasKey("Id");

                    b.ToTable("Passageiros");
                });

            modelBuilder.Entity("ProjetoAgencia.Models.Transporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTransporte");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeTransporte")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NomeTransporte");

                    b.HasKey("Id");

                    b.ToTable("Transporte");
                });

            modelBuilder.Entity("ProjetoAgencia.Models.Cadastro", b =>
                {
                    b.HasOne("ProjetoAgencia.Models.Atracoes", "Atracoes")
                        .WithMany()
                        .HasForeignKey("AtracoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoAgencia.Models.Destino", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoAgencia.Models.Estadia", "Estadia")
                        .WithMany()
                        .HasForeignKey("EstadiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoAgencia.Models.Passageiros", "Passageiros")
                        .WithMany()
                        .HasForeignKey("PassageirosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoAgencia.Models.Transporte", "Transporte")
                        .WithMany()
                        .HasForeignKey("TransporteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atracoes");

                    b.Navigation("Destino");

                    b.Navigation("Estadia");

                    b.Navigation("Passageiros");

                    b.Navigation("Transporte");
                });
#pragma warning restore 612, 618
        }
    }
}
