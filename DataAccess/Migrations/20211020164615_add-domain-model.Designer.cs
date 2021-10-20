﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using dat250_blazor_evaluation.DataAccess.Data;

namespace dat250blazorevaluation.DataAccess.Migrations
{
    [DbContext(typeof(VoteAppDbContext))]
    [Migration("20211020164615_add-domain-model")]
    partial class adddomainmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.IoTDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Identifier")
                        .HasColumnType("text");

                    b.Property<int?>("PollId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("IoTDevices");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("JoinCode")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("StopTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("TemplateId")
                        .HasColumnType("integer");

                    b.Property<int?>("VoteCountId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TemplateId");

                    b.HasIndex("VoteCountId");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.PollTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("GreenAnswer")
                        .HasColumnType("text");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.Property<string>("RedAnswer")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("PollTemplates");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.VoteCount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("GreenVotes")
                        .HasColumnType("integer");

                    b.Property<int>("RedVotes")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("VoteCounts");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.VoterProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VoterProfiles");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.IoTDevice", b =>
                {
                    b.HasOne("dat250_blazor_evaluation.DataAccess.Data.Poll", null)
                        .WithMany("IoTDevices")
                        .HasForeignKey("PollId");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.Poll", b =>
                {
                    b.HasOne("dat250_blazor_evaluation.DataAccess.Data.PollTemplate", "Template")
                        .WithMany("Polls")
                        .HasForeignKey("TemplateId");

                    b.HasOne("dat250_blazor_evaluation.DataAccess.Data.VoteCount", "VoteCount")
                        .WithMany()
                        .HasForeignKey("VoteCountId");

                    b.Navigation("Template");

                    b.Navigation("VoteCount");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.PollTemplate", b =>
                {
                    b.HasOne("dat250_blazor_evaluation.DataAccess.Data.VoterProfile", "Creator")
                        .WithMany("PollTemplates")
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.Poll", b =>
                {
                    b.Navigation("IoTDevices");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.PollTemplate", b =>
                {
                    b.Navigation("Polls");
                });

            modelBuilder.Entity("dat250_blazor_evaluation.DataAccess.Data.VoterProfile", b =>
                {
                    b.Navigation("PollTemplates");
                });
#pragma warning restore 612, 618
        }
    }
}
