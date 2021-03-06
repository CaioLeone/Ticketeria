// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoTicket.Data;

#nullable disable

namespace ProjetoTicket.Migrations
{
    [DbContext(typeof(TicketDbContext))]
    partial class TicketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AssentoSala", b =>
                {
                    b.Property<int>("AssentosId")
                        .HasColumnType("int");

                    b.Property<int>("SalasId")
                        .HasColumnType("int");

                    b.HasKey("AssentosId", "SalasId");

                    b.HasIndex("SalasId");

                    b.ToTable("AssentoSala");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Assento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Assentos");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoriasId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Datas")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriasId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Local", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EventosId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EventosId");

                    b.ToTable("Locals");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("LocaisId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("LocaisId");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("AssentoSala", b =>
                {
                    b.HasOne("ProjetoTicket.Models.Assento", null)
                        .WithMany()
                        .HasForeignKey("AssentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoTicket.Models.Sala", null)
                        .WithMany()
                        .HasForeignKey("SalasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoTicket.Models.Evento", b =>
                {
                    b.HasOne("ProjetoTicket.Models.Categoria", "Categorias")
                        .WithMany("Eventos")
                        .HasForeignKey("CategoriasId");

                    b.Navigation("Categorias");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Local", b =>
                {
                    b.HasOne("ProjetoTicket.Models.Evento", "Eventos")
                        .WithMany("Locais")
                        .HasForeignKey("EventosId");

                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Sala", b =>
                {
                    b.HasOne("ProjetoTicket.Models.Local", "Locais")
                        .WithMany("Salas")
                        .HasForeignKey("LocaisId");

                    b.Navigation("Locais");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Categoria", b =>
                {
                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Evento", b =>
                {
                    b.Navigation("Locais");
                });

            modelBuilder.Entity("ProjetoTicket.Models.Local", b =>
                {
                    b.Navigation("Salas");
                });
#pragma warning restore 612, 618
        }
    }
}
