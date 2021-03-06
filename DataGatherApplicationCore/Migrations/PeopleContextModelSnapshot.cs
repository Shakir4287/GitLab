﻿// <auto-generated />
using DataGatherApplicationCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataGatherApplicationCore.Migrations
{
    [DbContext(typeof(PeopleContext))]
    partial class PeopleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataGatherApplicationCore.Models.People", b =>
                {
                    b.Property<int>("PeopleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PeopleAddress")
                        .IsRequired();

                    b.Property<string>("PeopleCity")
                        .IsRequired();

                    b.Property<string>("PeopleCountry")
                        .IsRequired();

                    b.Property<string>("PeopleFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PeopleLastName")
                        .IsRequired();

                    b.Property<int>("PeoplePhoneNumber");

                    b.Property<string>("PeopleProfession")
                        .IsRequired();

                    b.HasKey("PeopleID");

                    b.ToTable("peoples");
                });
#pragma warning restore 612, 618
        }
    }
}
