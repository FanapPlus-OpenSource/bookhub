﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web;

namespace Web.Migrations
{
    [DbContext(typeof(BookHubDbContext))]
    partial class BookHubDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.Literature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasMaxLength(1000);

                    b.Property<int?>("PublicationId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Translator");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("PublicationId");

                    b.ToTable("LiteratureSet");
                });

            modelBuilder.Entity("Web.Models.LiteratureCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<int?>("LiteratureId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LiteratureId");

                    b.ToTable("LiteratureCategory");
                });

            modelBuilder.Entity("Web.Models.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Publication");
                });

            modelBuilder.Entity("Web.Models.Literature", b =>
                {
                    b.HasOne("Web.Models.Publication", "Publication")
                        .WithMany()
                        .HasForeignKey("PublicationId");
                });

            modelBuilder.Entity("Web.Models.LiteratureCategory", b =>
                {
                    b.HasOne("Web.Models.Literature")
                        .WithMany("Categories")
                        .HasForeignKey("LiteratureId");
                });
#pragma warning restore 612, 618
        }
    }
}
