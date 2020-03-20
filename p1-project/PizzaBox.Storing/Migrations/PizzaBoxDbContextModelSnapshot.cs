﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing.Databases;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxDbContext))]
    partial class PizzaBoxDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("StoreId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("OrderId");

                    b.HasIndex("StoreId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            OrderId = 1L,
                            OrderDateTime = new DateTime(2020, 1, 1, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 1L,
                            UserId = 1L
                        },
                        new
                        {
                            OrderId = 2L,
                            OrderDateTime = new DateTime(2020, 1, 2, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 2L,
                            UserId = 1L
                        },
                        new
                        {
                            OrderId = 3L,
                            OrderDateTime = new DateTime(2020, 1, 3, 1, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 3L,
                            UserId = 2L
                        },
                        new
                        {
                            OrderId = 4L,
                            OrderDateTime = new DateTime(2020, 2, 11, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 1L,
                            UserId = 2L
                        },
                        new
                        {
                            OrderId = 5L,
                            OrderDateTime = new DateTime(2020, 2, 12, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 2L,
                            UserId = 3L
                        },
                        new
                        {
                            OrderId = 6L,
                            OrderDateTime = new DateTime(2020, 2, 13, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 3L,
                            UserId = 3L
                        },
                        new
                        {
                            OrderId = 7L,
                            OrderDateTime = new DateTime(2020, 3, 21, 3, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 1L,
                            UserId = 4L
                        },
                        new
                        {
                            OrderId = 8L,
                            OrderDateTime = new DateTime(2020, 3, 22, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 2L,
                            UserId = 4L
                        },
                        new
                        {
                            OrderId = 9L,
                            OrderDateTime = new DateTime(2020, 3, 23, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            StoreId = 3L,
                            UserId = 5L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.OrderPizza", b =>
                {
                    b.Property<long>("OrderPizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("PizzaId")
                        .HasColumnType("bigint");

                    b.HasKey("OrderPizzaId");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("OrderPizza");

                    b.HasData(
                        new
                        {
                            OrderPizzaId = 1L,
                            OrderId = 1L,
                            PizzaId = 1L
                        },
                        new
                        {
                            OrderPizzaId = 2L,
                            OrderId = 2L,
                            PizzaId = 2L
                        },
                        new
                        {
                            OrderPizzaId = 3L,
                            OrderId = 3L,
                            PizzaId = 3L
                        },
                        new
                        {
                            OrderPizzaId = 4L,
                            OrderId = 4L,
                            PizzaId = 4L
                        },
                        new
                        {
                            OrderPizzaId = 5L,
                            OrderId = 5L,
                            PizzaId = 5L
                        },
                        new
                        {
                            OrderPizzaId = 6L,
                            OrderId = 6L,
                            PizzaId = 6L
                        },
                        new
                        {
                            OrderPizzaId = 7L,
                            OrderId = 7L,
                            PizzaId = 7L
                        },
                        new
                        {
                            OrderPizzaId = 8L,
                            OrderId = 8L,
                            PizzaId = 8L
                        },
                        new
                        {
                            OrderPizzaId = 9L,
                            OrderId = 9L,
                            PizzaId = 9L
                        },
                        new
                        {
                            OrderPizzaId = 10L,
                            OrderId = 9L,
                            PizzaId = 10L
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PizzaDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PizzaPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PizzaId");

                    b.ToTable("Pizza");

                    b.HasData(
                        new
                        {
                            PizzaId = 1L,
                            PizzaDetails = "Uncooked Pizza Dough",
                            PizzaName = "The Worst Pizza",
                            PizzaPrice = 1.00m
                        },
                        new
                        {
                            PizzaId = 2L,
                            PizzaDetails = "Cooked Pizza Dough",
                            PizzaName = "The Best Pizza",
                            PizzaPrice = 2.00m
                        },
                        new
                        {
                            PizzaId = 3L,
                            PizzaDetails = "Thin Crust, Medium Size, ",
                            PizzaName = "The Dominic",
                            PizzaPrice = 3.00m
                        },
                        new
                        {
                            PizzaId = 4L,
                            PizzaDetails = "Thick Crust, Large Size, Tomato Sauce, Tomato Sauce, Tomato Sauce, Tomato Sauce",
                            PizzaName = "The Fred",
                            PizzaPrice = 4.00m
                        },
                        new
                        {
                            PizzaId = 5L,
                            PizzaDetails = "Traditional Crust, Tomato Sauce, Mozarella Cheese",
                            PizzaName = "The Frank",
                            PizzaPrice = 5.00m
                        },
                        new
                        {
                            PizzaId = 6L,
                            PizzaDetails = "Paper, Pencil",
                            PizzaName = "The Me Hoy Minoy",
                            PizzaPrice = 6.00m
                        },
                        new
                        {
                            PizzaId = 7L,
                            PizzaDetails = "Thin Crust, Small Size, Tomato Sauce, Mozarella Cheese, Ground Beef, Allspice",
                            PizzaName = "The Sweat",
                            PizzaPrice = 7.00m
                        },
                        new
                        {
                            PizzaId = 8L,
                            PizzaDetails = "Traditional Crust, Large Size, Mozarella Cheese, Pesto Dollops, White Sauce, Chicken, Green Bell Peppers, Red Onions",
                            PizzaName = "The Hallowus",
                            PizzaPrice = 8.00m
                        },
                        new
                        {
                            PizzaId = 9L,
                            PizzaDetails = "Thick Crust, Tomato Sauce, Bacon, Eggs, Cheese, Corn",
                            PizzaName = "The Pupit",
                            PizzaPrice = 9.00m
                        },
                        new
                        {
                            PizzaId = 10L,
                            PizzaDetails = "Eugh",
                            PizzaName = "The Puffer",
                            PizzaPrice = 9.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StoreAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            StoreId = 1L,
                            StoreAddress = "16573 Wallaby Ln",
                            StoreName = "Fred's Pizzeria"
                        },
                        new
                        {
                            StoreId = 2L,
                            StoreAddress = "6678 This Street St",
                            StoreName = "Not Your Mom's Pizza"
                        },
                        new
                        {
                            StoreId = 3L,
                            StoreAddress = "29394 Calhoun Dr",
                            StoreName = "My Mom's Pizza"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            FirstName = "Ted1",
                            LastName = "Willis1",
                            UserAddress = "Place1"
                        },
                        new
                        {
                            UserId = 2L,
                            FirstName = "Ted2",
                            LastName = "Willis2",
                            UserAddress = "Place2"
                        },
                        new
                        {
                            UserId = 3L,
                            FirstName = "Ted3",
                            LastName = "Willis3",
                            UserAddress = "Place3"
                        },
                        new
                        {
                            UserId = 4L,
                            FirstName = "Ted4",
                            LastName = "Willis4",
                            UserAddress = "Place4"
                        },
                        new
                        {
                            UserId = 5L,
                            FirstName = "Ted5",
                            LastName = "Willis5",
                            UserAddress = "Place5"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Store", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.OrderPizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("OrderPizzas")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Pizza", "Pizza")
                        .WithMany("OrderPizzas")
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}