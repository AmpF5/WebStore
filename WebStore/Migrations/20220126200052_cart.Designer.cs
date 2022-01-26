﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.Models;

namespace WebStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220126200052_cart")]
    partial class cart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "klawiatura mechaniczna",
                            CategoryName = "Mechaniczna"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "klawiatura membranowa",
                            CategoryName = "Membranowa"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "klawiatura hybrydowa",
                            CategoryName = "Hybrydowa"
                        });
                });

            modelBuilder.Entity("WebStore.Models.Keyboard", b =>
                {
                    b.Property<int>("KeyboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dpi")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("KeyboardId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Keyboards");

                    b.HasData(
                        new
                        {
                            KeyboardId = 1,
                            CategoryId = 1,
                            Description = "klawiatura corsiar k100",
                            Dpi = 0,
                            ImageThumbnailUrl = "\\Images\\corsairk100.jpg",
                            ImageUrl = "\\Images\\corsairk100.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "Corsair k100",
                            Price = 899.99m
                        });
                });

            modelBuilder.Entity("WebStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("KeyboardId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("KeyboardId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("WebStore.Models.Keyboard", b =>
                {
                    b.HasOne("WebStore.Models.Category", "Category")
                        .WithMany("Keyboards")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("WebStore.Models.Keyboard", "Keyboard")
                        .WithMany()
                        .HasForeignKey("KeyboardId");
                });
#pragma warning restore 612, 618
        }
    }
}
