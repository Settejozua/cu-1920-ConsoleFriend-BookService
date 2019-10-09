﻿// <auto-generated />
using System;
using BookService.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookService.WebAPI.Migrations
{
    [DbContext(typeof(BookServiceContext))]
    partial class BookServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookService.WebAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime?>("CreatedDateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 255, DateTimeKind.Local).AddTicks(5532),
                            FirstName = "James",
                            LastName = "Sharp"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1992, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 255, DateTimeKind.Local).AddTicks(5618),
                            FirstName = "Sophie",
                            LastName = "Netty"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 255, DateTimeKind.Local).AddTicks(5681),
                            FirstName = "Elisa",
                            LastName = "Yammy"
                        });
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<DateTime?>("CreatedDateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("FileName");

                    b.Property<string>("ISBN");

                    b.Property<int>("NumberOfPages");

                    b.Property<decimal>("Price");

                    b.Property<int>("PublisherId");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            FileName = "book1.jpg",
                            ISBN = "123456789",
                            NumberOfPages = 420,
                            Price = 24.99m,
                            PublisherId = 1,
                            Title = "Learning C#",
                            Year = 2018
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            FileName = "book2.jpg",
                            ISBN = "45689132",
                            NumberOfPages = 360,
                            Price = 35.99m,
                            PublisherId = 1,
                            Title = "Mastering Linq",
                            Year = 2016
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            FileName = "book3.jpg",
                            ISBN = "15856135",
                            NumberOfPages = 360,
                            Price = 50.00m,
                            PublisherId = 1,
                            Title = "Mastering Xamarin",
                            Year = 2017
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            FileName = "book1.jpg",
                            ISBN = "56789564",
                            NumberOfPages = 360,
                            Price = 45.00m,
                            PublisherId = 1,
                            Title = "Exploring ASP.Net Core 2.0",
                            Year = 2018
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            FileName = "book2.jpg",
                            ISBN = "234546684",
                            NumberOfPages = 420,
                            Price = 70.50m,
                            PublisherId = 1,
                            Title = "Unity Game Development",
                            Year = 2017
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 3,
                            FileName = "book3.jpg",
                            ISBN = "789456258",
                            NumberOfPages = 40,
                            Price = 52.00m,
                            PublisherId = 2,
                            Title = "Cooking is fun",
                            Year = 2007
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 3,
                            FileName = "book3.jpg",
                            ISBN = "94521546",
                            NumberOfPages = 53,
                            Price = 30.00m,
                            PublisherId = 2,
                            Title = "Secret recipes",
                            Year = 2017
                        });
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<DateTime?>("CreatedDateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publisher");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "UK",
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(609),
                            Name = "IT-publishers"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Sweden",
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(675),
                            Name = "FoodBooks"
                        });
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime?>("CreatedDateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ReaderId");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ReaderId");

                    b.ToTable("Rating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 1,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(1987),
                            ReaderId = 1,
                            Score = 3
                        },
                        new
                        {
                            Id = 2,
                            BookId = 2,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(2069),
                            ReaderId = 1,
                            Score = 2
                        },
                        new
                        {
                            Id = 3,
                            BookId = 3,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(2137),
                            ReaderId = 2,
                            Score = 5
                        },
                        new
                        {
                            Id = 4,
                            BookId = 1,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(2203),
                            ReaderId = 2,
                            Score = 4
                        },
                        new
                        {
                            Id = 5,
                            BookId = 2,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(2329),
                            ReaderId = 3,
                            Score = 2
                        },
                        new
                        {
                            Id = 6,
                            BookId = 3,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(2396),
                            ReaderId = 3,
                            Score = 3
                        });
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDateTime")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Reader");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(4048),
                            FirstName = "Joe",
                            LastName = "Pageturner"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(4117),
                            FirstName = "Linda",
                            LastName = "Bookslaughter"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDateTime = new DateTime(2019, 10, 3, 15, 21, 31, 256, DateTimeKind.Local).AddTicks(4184),
                            FirstName = "Wendy",
                            LastName = "Allreader"
                        });
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Book", b =>
                {
                    b.HasOne("BookService.WebAPI.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookService.WebAPI.Models.Publisher", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookService.WebAPI.Models.Rating", b =>
                {
                    b.HasOne("BookService.WebAPI.Models.Book", "Book")
                        .WithMany("Ratings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookService.WebAPI.Models.Reader", "Reader")
                        .WithMany("Ratings")
                        .HasForeignKey("ReaderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
