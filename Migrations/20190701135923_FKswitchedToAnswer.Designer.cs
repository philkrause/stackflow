﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using stackflow;

namespace sdgreacttemplate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190701135923_FKswitchedToAnswer")]
    partial class FKswitchedToAnswer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("stackflow.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("QuestionTableId");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTableId");

                    b.ToTable("AnswerTable");
                });

            modelBuilder.Entity("stackflow.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.Property<int>("VoteCount");

                    b.HasKey("Id");

                    b.ToTable("QuestionTable");
                });

            modelBuilder.Entity("stackflow.Models.Answer", b =>
                {
                    b.HasOne("stackflow.Models.Question", "QuestionTable")
                        .WithMany("AnswerTable")
                        .HasForeignKey("QuestionTableId");
                });
#pragma warning restore 612, 618
        }
    }
}
