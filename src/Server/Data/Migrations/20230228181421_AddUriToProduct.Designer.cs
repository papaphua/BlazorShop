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
    [Migration("20230228181421_AddUriToProduct")]
    partial class AddUriToProduct
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
                            Id = new Guid("2ba4c93a-4a24-4499-8f99-222687ff60ae"),
                            Name = "Books",
                            Uri = "books"
                        },
                        new
                        {
                            Id = new Guid("1d65fe2d-6ee1-427f-b34d-f62c1cc080a2"),
                            Name = "Movies",
                            Uri = "movies"
                        },
                        new
                        {
                            Id = new Guid("c5fe5148-c98a-417a-a4ce-316527251e53"),
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

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            PermissionId = 1
                        });
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

                    b.Property<string>("ImageUrl")
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
                            Id = new Guid("928ff29a-2036-4c5b-8c85-5daa5056d2c5"),
                            CategoryId = new Guid("2ba4c93a-4a24-4499-8f99-222687ff60ae"),
                            Description = "The Hitchhiker's Guide to the Galaxy is a comedy science fiction franchise created by Douglas Adams.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            Name = "The Hitchhiker's Guide to the Galaxy",
                            Price = 9.99m,
                            Uri = "the-hitchhiker's-guide-to-the-galaxy"
                        },
                        new
                        {
                            Id = new Guid("651f367c-e82e-4ef9-afa7-f75ed390d724"),
                            CategoryId = new Guid("2ba4c93a-4a24-4499-8f99-222687ff60ae"),
                            Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                            Name = "Ready Player One",
                            Price = 7.99m,
                            Uri = "ready-player-one"
                        },
                        new
                        {
                            Id = new Guid("324235a8-a3cb-4b3e-9b0e-5d86aea87c26"),
                            CategoryId = new Guid("2ba4c93a-4a24-4499-8f99-222687ff60ae"),
                            Description = "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by the English writer George Orwell.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/330px-1984first.jpg",
                            Name = "Nineteen Eighty-Four",
                            Price = 6.99m,
                            Uri = "nineteen-eighty-four"
                        },
                        new
                        {
                            Id = new Guid("ef17f681-732f-49af-86c6-21c8ee51101e"),
                            CategoryId = new Guid("1d65fe2d-6ee1-427f-b34d-f62c1cc080a2"),
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Name = "The Matrix",
                            Price = 8.99m,
                            Uri = "the-matrix"
                        },
                        new
                        {
                            Id = new Guid("87de6bbd-f300-436b-a4e3-639eaa7ae1d4"),
                            CategoryId = new Guid("1d65fe2d-6ee1-427f-b34d-f62c1cc080a2"),
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Name = "Back to the Future",
                            Price = 10.39m,
                            Uri = "back-to-the-future"
                        },
                        new
                        {
                            Id = new Guid("59286998-9b22-4f0e-a934-7dedf423ba22"),
                            CategoryId = new Guid("1d65fe2d-6ee1-427f-b34d-f62c1cc080a2"),
                            Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                            Name = "Toy Story",
                            Price = 9.39m,
                            Uri = "toy-story"
                        },
                        new
                        {
                            Id = new Guid("7892fe64-ecb1-4cb1-92b8-c8032c29491b"),
                            CategoryId = new Guid("c5fe5148-c98a-417a-a4ce-316527251e53"),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            Name = "Half-Life 2",
                            Price = 3.29m,
                            Uri = "half-life-2"
                        },
                        new
                        {
                            Id = new Guid("695ff4ad-358e-4800-8b17-a335cc69bfcd"),
                            CategoryId = new Guid("c5fe5148-c98a-417a-a4ce-316527251e53"),
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            Name = "Diablo II",
                            Price = 4.29m,
                            Uri = "diablo-ii"
                        },
                        new
                        {
                            Id = new Guid("0da11194-c7e6-4d8d-af38-77e65332905b"),
                            CategoryId = new Guid("c5fe5148-c98a-417a-a4ce-316527251e53"),
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            Name = "Day of the Tentacle",
                            Price = 5.55m,
                            Uri = "day-of-the-tentacle"
                        },
                        new
                        {
                            Id = new Guid("74d171d9-99a2-4040-8138-ada7abe66558"),
                            CategoryId = new Guid("c5fe5148-c98a-417a-a4ce-316527251e53"),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            Name = "Xbox",
                            Price = 29.99m,
                            Uri = "xbox"
                        },
                        new
                        {
                            Id = new Guid("3757b322-f914-42be-a9ed-cbf15d874520"),
                            CategoryId = new Guid("c5fe5148-c98a-417a-a4ce-316527251e53"),
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            Name = "Super Nintendo Entertainment System",
                            Price = 19.99m,
                            Uri = "super-nintendo-entertainment-system"
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
