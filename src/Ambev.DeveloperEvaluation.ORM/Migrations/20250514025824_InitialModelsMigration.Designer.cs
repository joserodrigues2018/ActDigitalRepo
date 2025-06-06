﻿// <auto-generated />
using System;
using Ambev.DeveloperEvaluation.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ambev.DeveloperEvaluation.ORM.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20250514025824_InitialModelsMigration")]
    partial class InitialModelsMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .HasColumnType("text");


                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.CartItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CartId")
                        .HasColumnType("uuid");


                    b.Property<string>("ProductId")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");


                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("CartItens");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<decimal>("Price")
                        .HasPrecision(5, 2)
                        .HasColumnType("numeric(5,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f6b69aa6-e2f3-43f6-a05e-bd2197665248"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 1.50m,
                            Title = "Produto Teste1"
                        },
                        new
                        {
                            Id = new Guid("8c49293a-cb5d-4d5e-b974-b684d760e68b"),
                            Category = "Alimentos",
                            Description = "batata doce",
                            Image = "Image1",
                            Price = 20.5m,
                            Title = "Produto Teste2"
                        },
                        new
                        {
                            Id = new Guid("99e3da6e-a480-4f5f-8058-03f4a6840e88"),
                            Category = "Alimentos",
                            Description = "tomnate",
                            Image = "Image1",
                            Price = 2.50m,
                            Title = "Produto Teste3"
                        },
                        new
                        {
                            Id = new Guid("fb461642-0ab9-4c35-b267-db7245389144"),
                            Category = "Alimentos",
                            Description = "cebola",
                            Image = "Image1",
                            Price = 3.59m,
                            Title = "Produto Teste4"
                        },
                        new
                        {
                            Id = new Guid("053fe689-6338-4888-838f-f2d6e380320c"),
                            Category = "Alimentos",
                            Description = "farrinha",
                            Image = "Image1",
                            Price = 10.90m,
                            Title = "Produto Teste5"
                        },
                        new
                        {
                            Id = new Guid("234da59d-1e6c-426a-b63f-ca25991fadbb"),
                            Category = "Alimentos",
                            Description = "macarrao",
                            Image = "Image1",
                            Price = 11.30m,
                            Title = "Produto Teste6"
                        },
                        new
                        {
                            Id = new Guid("e08e8a39-a99f-44b8-9d02-7204edc46b20"),
                            Category = "Alimentos",
                            Description = "conserva",
                            Image = "Image1",
                            Price = 12.70m,
                            Title = "Produto Teste7"
                        },
                        new
                        {
                            Id = new Guid("50d5ceb1-a8a4-4f3a-beb5-5c5da018635b"),
                            Category = "Alimentos",
                            Description = "doce de leite",
                            Image = "Image1",
                            Price = 20.50m,
                            Title = "Produto Teste8"
                        },
                        new
                        {
                            Id = new Guid("7085290f-4c94-41b6-a26b-6942043b8284"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 21.50m,
                            Title = "Produto Teste9"
                        },
                        new
                        {
                            Id = new Guid("6889f9b5-e741-4356-a803-b9937cb3f431"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 22.50m,
                            Title = "Produto Teste10"
                        },
                        new
                        {
                            Id = new Guid("aa7955f3-6849-479a-810f-5009a44e7ffd"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 23.75m,
                            Title = "Produto Teste11"
                        },
                        new
                        {
                            Id = new Guid("0550fb96-50e5-4968-acc3-0af01870a18d"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 150.03m,
                            Title = "Produto Teste12"
                        },
                        new
                        {
                            Id = new Guid("74a0cc42-a507-4af2-abd7-a6bd60dc601c"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 48.76m,
                            Title = "Produto Teste13"
                        },
                        new
                        {
                            Id = new Guid("57ac8ad9-7c66-42db-aae7-ede32745aeb4"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 55.76m,
                            Title = "Produto Teste14"
                        },
                        new
                        {
                            Id = new Guid("9023a0cd-6ac3-497f-be5e-6d528f7a9447"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 40.00m,
                            Title = "Produto Teste15"
                        },
                        new
                        {
                            Id = new Guid("837c5d3a-537e-41e4-a1fc-205fe0800ed3"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 100.51m,
                            Title = "Produto Teste16"
                        },
                        new
                        {
                            Id = new Guid("b6ab9232-1fe8-40d3-9d5d-828b11041a2a"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 200.47m,
                            Title = "Produto Teste17"
                        },
                        new
                        {
                            Id = new Guid("c88ed001-4713-43e2-ab26-5afb06866daa"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 3.50m,
                            Title = "Produto Teste18"
                        },
                        new
                        {
                            Id = new Guid("0773a99f-40d2-4c24-8aaf-7d45e42ab856"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 4.50m,
                            Title = "Produto Teste19"
                        },
                        new
                        {
                            Id = new Guid("dc141325-4397-4608-a3f5-e2d99fbeea2b"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 5.50m,
                            Title = "Produto Teste20"
                        },
                        new
                        {
                            Id = new Guid("a0c0949c-c7fa-401f-8fcf-4874906bbd0b"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 6.50m,
                            Title = "Produto Teste21"
                        },
                        new
                        {
                            Id = new Guid("6105ddfe-636a-40b2-b3ec-77b695d2a528"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 7.50m,
                            Title = "Produto Teste22"
                        },
                        new
                        {
                            Id = new Guid("9f0f5a2f-6cca-459d-ad4e-133402183019"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 8.50m,
                            Title = "Produto Teste23"
                        },
                        new
                        {
                            Id = new Guid("b7301b08-10a7-4f88-b4ae-639bddf522cd"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 9.50m,
                            Title = "Produto Teste24"
                        },
                        new
                        {
                            Id = new Guid("6e94c72e-6c44-4068-a3ed-5868ad28f5bf"),
                            Category = "Alimentos",
                            Description = "Leite em liquido",
                            Image = "Image1",
                            Price = 0.50m,
                            Title = "Produto Teste25"
                        });
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("gen_random_uuid()");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("Ambev.DeveloperEvaluation.Domain.Entities.Cart", "CartIdNav")
                        .WithMany("CartItens")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CartIdNav");
                });

            modelBuilder.Entity("Ambev.DeveloperEvaluation.Domain.Entities.Cart", b =>
                {
                    b.Navigation("CartItens");
                });
#pragma warning restore 612, 618
        }
    }
}
