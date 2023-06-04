﻿// <auto-generated />
using System;
using Common.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Common.Migrations
{
    [DbContext(typeof(CommentsContext))]
    partial class CommentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Common.EntityFramework.Comment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AuthorId")
                        .HasColumnType("bigint");

                    b.Property<long>("CommentId")
                        .HasColumnType("bigint");

                    b.Property<long>("GroupId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PostId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Common.EntityFramework.EvaluatedComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("CommentId")
                        .HasColumnType("bigint");

                    b.Property<string>("EvaluateCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EvaluateProbability")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("EvaluatedComments");
                });

            modelBuilder.Entity("Common.EntityFramework.EvaluatedComment", b =>
                {
                    b.HasOne("Common.EntityFramework.Comment", "RelatedComment")
                        .WithMany("IncludedInEvaluatedComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelatedComment");
                });

            modelBuilder.Entity("Common.EntityFramework.Comment", b =>
                {
                    b.Navigation("IncludedInEvaluatedComments");
                });
#pragma warning restore 612, 618
        }
    }
}