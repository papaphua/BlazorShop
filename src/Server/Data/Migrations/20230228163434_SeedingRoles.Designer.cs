﻿// <auto-generated />
using System;
using BlazorShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorShop.Server.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230228163434_SeedingRoles")]
    partial class SeedingRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("88f63a98-1e18-4d6a-8119-646fd857c811"),
                            Name = "Books",
                            Uri = "books"
                        },
                        new
                        {
                            Id = new Guid("1d6bf658-f7ad-46b3-b89f-013a6befe2ae"),
                            Name = "Movies",
                            Uri = "movies"
                        },
                        new
                        {
                            Id = new Guid("8f1fdfd6-c292-4616-b54d-95cdd94df1be"),
                            Name = "Video Games",
                            Uri = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comment", (string)null);
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.JointEntities.ProductComment", b =>
                {
                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("ProductComment", (string)null);
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.JointEntities.RolePermission", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermission", (string)null);
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.JointEntities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permission", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CustomerPermission"
                        },
                        new
                        {
                            Id = 2,
                            Name = "AdminPermission"
                        });
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c3413f6a-8cb5-45cc-95a3-284e0651a377"),
                            CategoryId = new Guid("88f63a98-1e18-4d6a-8119-646fd857c811"),
                            Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams.",
                            Name = "The Hitchhiker's Guide to the Galaxy",
                            Price = 9.99m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg"
                        },
                        new
                        {
                            Id = new Guid("f083dd7e-93de-458e-a006-729c6051491b"),
                            CategoryId = new Guid("88f63a98-1e18-4d6a-8119-646fd857c811"),
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.",
                            Name = "Ready Player One",
                            Price = 7.99m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg"
                        },
                        new
                        {
                            Id = new Guid("d2880df4-d96c-4518-baa0-4475caedc7af"),
                            CategoryId = new Guid("88f63a98-1e18-4d6a-8119-646fd857c811"),
                            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell.",
                            Name = "Nineteen Eighty-Four",
                            Price = 6.99m,
                            Uri = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/330px-1984first.jpg"
                        },
                        new
                        {
                            Id = new Guid("49ad6e98-c372-4f1d-ba02-ddbc3c50a2b2"),
                            CategoryId = new Guid("1d6bf658-f7ad-46b3-b89f-013a6befe2ae"),
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            Name = "The Matrix",
                            Price = 8.99m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg"
                        },
                        new
                        {
                            Id = new Guid("c5b5113c-6ef1-4657-9ad8-7c17db352e54"),
                            CategoryId = new Guid("1d6bf658-f7ad-46b3-b89f-013a6befe2ae"),
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Name = "Back to the Future",
                            Price = 10.39m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg"
                        },
                        new
                        {
                            Id = new Guid("59fd64f7-ec7f-438d-b1d4-bbebc20bcca7"),
                            CategoryId = new Guid("1d6bf658-f7ad-46b3-b89f-013a6befe2ae"),
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Name = "Toy Story",
                            Price = 9.39m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg"
                        },
                        new
                        {
                            Id = new Guid("e029324d-5b78-4407-822c-a08adc71358f"),
                            CategoryId = new Guid("8f1fdfd6-c292-4616-b54d-95cdd94df1be"),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Name = "Half-Life 2",
                            Price = 3.29m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg"
                        },
                        new
                        {
                            Id = new Guid("f710b6a2-6d4c-4754-b8fc-03992b329fbc"),
                            CategoryId = new Guid("8f1fdfd6-c292-4616-b54d-95cdd94df1be"),
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Name = "Diablo II",
                            Price = 4.29m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png"
                        },
                        new
                        {
                            Id = new Guid("04df0aef-e2f7-47ed-b6cb-b456a2f1ed8c"),
                            CategoryId = new Guid("8f1fdfd6-c292-4616-b54d-95cdd94df1be"),
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Name = "Day of the Tentacle",
                            Price = 5.55m,
                            Uri = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg"
                        },
                        new
                        {
                            Id = new Guid("ec04eda6-1533-4317-8463-f6447dd4ee19"),
                            CategoryId = new Guid("8f1fdfd6-c292-4616-b54d-95cdd94df1be"),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Name = "Xbox",
                            Price = 29.99m,
                            Uri = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg"
                        },
                        new
                        {
                            Id = new Guid("dac25194-5b61-414f-abfa-8d2119c2db31"),
                            CategoryId = new Guid("8f1fdfd6-c292-4616-b54d-95cdd94df1be"),
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Name = "Super Nintendo Entertainment System",
                            Price = 19.99m,
                            Uri = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg"
                        });
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Customer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Comment", b =>
                {
                    b.HasOne("BlazorShop.Server.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.JointEntities.ProductComment", b =>
                {
                    b.HasOne("BlazorShop.Server.Data.Entities.Comment", null)
                        .WithMany()
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Server.Data.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.JointEntities.RolePermission", b =>
                {
                    b.HasOne("BlazorShop.Server.Data.Entities.Permission", null)
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Server.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.JointEntities.UserRole", b =>
                {
                    b.HasOne("BlazorShop.Server.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Server.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorShop.Server.Data.Entities.Product", b =>
                {
                    b.HasOne("BlazorShop.Server.Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}