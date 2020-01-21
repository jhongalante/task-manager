﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using task_manager;

namespace task_manager.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191203165638_Correcao")]
    partial class Correcao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("controle_de_tarefa_global.Models.Atividade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TarefaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataHoraPublicacao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TarefaId");

                    b.ToTable("Atividade");
                });

            modelBuilder.Entity("controle_de_tarefa_global.Models.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NivelUrgencia")
                        .HasColumnType("int");

                    b.Property<DateTime>("Prazo")
                        .HasColumnType("datetime2");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ResponsavelId");

                    b.ToTable("Tarefa");
                });

            modelBuilder.Entity("controle_de_tarefa_global.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Adm")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("controle_de_tarefa_global.Models.Atividade", b =>
                {
                    b.HasOne("controle_de_tarefa_global.Models.Tarefa", null)
                        .WithMany("HistoricoAtividades")
                        .HasForeignKey("TarefaId");
                });

            modelBuilder.Entity("controle_de_tarefa_global.Models.Tarefa", b =>
                {
                    b.HasOne("controle_de_tarefa_global.Models.Usuario", "Responsavel")
                        .WithMany("TarefasUsuario")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
