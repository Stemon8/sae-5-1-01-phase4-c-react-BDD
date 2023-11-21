﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20231121160656_AddCharacterSkills")]
    partial class AddCharacterSkills
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Data.Models.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("category");
                });

            modelBuilder.Entity("backend.Data.Models.Challenge", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("creator_team_id")
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("target_team_id")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("creator_team_id");

                    b.HasIndex("target_team_id");

                    b.ToTable("challenge");
                });

            modelBuilder.Entity("backend.Data.Models.Character", b =>
                {
                    b.Property<Guid>("id_character")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("id_user")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_character");

                    b.HasIndex("id_user");

                    b.ToTable("character");
                });

            modelBuilder.Entity("backend.Data.Models.CharacterSkill", b =>
                {
                    b.Property<Guid>("id_character_skill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("confidence_level")
                        .HasMaxLength(5)
                        .HasColumnType("integer");

                    b.Property<Guid>("id_character")
                        .HasColumnType("uuid");

                    b.Property<int>("id_skill")
                        .HasColumnType("integer");

                    b.HasKey("id_character_skill");

                    b.HasIndex("id_character");

                    b.HasIndex("id_skill");

                    b.ToTable("character_skill");
                });

            modelBuilder.Entity("backend.Data.Models.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("id_groupe_parent")
                        .HasColumnType("integer");

                    b.Property<int>("id_prom")
                        .HasColumnType("integer");

                    b.Property<bool>("is_apprenticeship")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("id_groupe_parent");

                    b.HasIndex("id_prom");

                    b.ToTable("group");
                });

            modelBuilder.Entity("backend.Data.Models.Prom", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("year")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("prom");
                });

            modelBuilder.Entity("backend.Data.Models.RoleUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("role_user");
                });

            modelBuilder.Entity("backend.Data.Models.Sae", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("id_prom")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("id_prom");

                    b.ToTable("sae");
                });

            modelBuilder.Entity("backend.Data.Models.Skill", b =>
                {
                    b.Property<int>("id_skill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_skill"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id_skill");

                    b.ToTable("skill");
                });

            modelBuilder.Entity("backend.Data.Models.Subject", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("Saeid")
                        .HasColumnType("integer");

                    b.Property<Guid>("category_id")
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Saeid");

                    b.HasIndex("category_id");

                    b.ToTable("subject");
                });

            modelBuilder.Entity("backend.Data.Models.Team", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("team");
                });

            modelBuilder.Entity("backend.Data.Models.TeamSubject", b =>
                {
                    b.Property<Guid>("subject_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("team_id")
                        .HasColumnType("uuid");

                    b.HasKey("subject_id", "team_id");

                    b.HasIndex("team_id");

                    b.ToTable("team_subject");
                });

            modelBuilder.Entity("backend.Data.Models.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("id_groupe")
                        .HasColumnType("integer");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("role_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("id_groupe");

                    b.HasIndex("role_id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("backend.Data.Models.UserTeam", b =>
                {
                    b.Property<Guid>("user_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("team_id")
                        .HasColumnType("uuid");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("user_id", "team_id");

                    b.HasIndex("team_id");

                    b.ToTable("user_equipe");
                });

            modelBuilder.Entity("backend.Data.Models.Wish", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("subject_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("team_id")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("subject_id");

                    b.HasIndex("team_id");

                    b.ToTable("wish");
                });

            modelBuilder.Entity("backend.Data.Models.Challenge", b =>
                {
                    b.HasOne("backend.Data.Models.Team", "creator_team")
                        .WithMany("creator_challenge")
                        .HasForeignKey("creator_team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Models.Team", "target_team")
                        .WithMany("target_challenge")
                        .HasForeignKey("target_team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("creator_team");

                    b.Navigation("target_team");
                });

            modelBuilder.Entity("backend.Data.Models.Character", b =>
                {
                    b.HasOne("backend.Data.Models.User", "user")
                        .WithMany("characters")
                        .HasForeignKey("id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("backend.Data.Models.CharacterSkill", b =>
                {
                    b.HasOne("backend.Data.Models.Character", "character")
                        .WithMany("character_skills")
                        .HasForeignKey("id_character")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Models.Skill", "skill")
                        .WithMany("character_skills")
                        .HasForeignKey("id_skill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("character");

                    b.Navigation("skill");
                });

            modelBuilder.Entity("backend.Data.Models.Group", b =>
                {
                    b.HasOne("backend.Data.Models.Group", "group_parent")
                        .WithMany("groups_childs")
                        .HasForeignKey("id_groupe_parent");

                    b.HasOne("backend.Data.Models.Prom", "prom")
                        .WithMany("groups")
                        .HasForeignKey("id_prom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("group_parent");

                    b.Navigation("prom");
                });

            modelBuilder.Entity("backend.Data.Models.Sae", b =>
                {
                    b.HasOne("backend.Data.Models.Prom", "prom")
                        .WithMany("saes")
                        .HasForeignKey("id_prom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("prom");
                });

            modelBuilder.Entity("backend.Data.Models.Subject", b =>
                {
                    b.HasOne("backend.Data.Models.Sae", null)
                        .WithMany("subjects")
                        .HasForeignKey("Saeid");

                    b.HasOne("backend.Data.Models.Category", "category")
                        .WithMany("subject")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("backend.Data.Models.TeamSubject", b =>
                {
                    b.HasOne("backend.Data.Models.Subject", "subject")
                        .WithMany("team_subject")
                        .HasForeignKey("subject_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Models.Team", "team")
                        .WithMany("team_subject")
                        .HasForeignKey("team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");

                    b.Navigation("team");
                });

            modelBuilder.Entity("backend.Data.Models.User", b =>
                {
                    b.HasOne("backend.Data.Models.Group", "group")
                        .WithMany("users")
                        .HasForeignKey("id_groupe");

                    b.HasOne("backend.Data.Models.RoleUser", "role_user")
                        .WithMany("users")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("group");

                    b.Navigation("role_user");
                });

            modelBuilder.Entity("backend.Data.Models.UserTeam", b =>
                {
                    b.HasOne("backend.Data.Models.Team", "team")
                        .WithMany("user_team")
                        .HasForeignKey("team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Models.User", "user")
                        .WithMany("user_team")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("team");

                    b.Navigation("user");
                });

            modelBuilder.Entity("backend.Data.Models.Wish", b =>
                {
                    b.HasOne("backend.Data.Models.Subject", "subject")
                        .WithMany("wish")
                        .HasForeignKey("subject_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Data.Models.Team", "team")
                        .WithMany("wish")
                        .HasForeignKey("team_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");

                    b.Navigation("team");
                });

            modelBuilder.Entity("backend.Data.Models.Category", b =>
                {
                    b.Navigation("subject");
                });

            modelBuilder.Entity("backend.Data.Models.Character", b =>
                {
                    b.Navigation("character_skills");
                });

            modelBuilder.Entity("backend.Data.Models.Group", b =>
                {
                    b.Navigation("groups_childs");

                    b.Navigation("users");
                });

            modelBuilder.Entity("backend.Data.Models.Prom", b =>
                {
                    b.Navigation("groups");

                    b.Navigation("saes");
                });

            modelBuilder.Entity("backend.Data.Models.RoleUser", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("backend.Data.Models.Sae", b =>
                {
                    b.Navigation("subjects");
                });

            modelBuilder.Entity("backend.Data.Models.Skill", b =>
                {
                    b.Navigation("character_skills");
                });

            modelBuilder.Entity("backend.Data.Models.Subject", b =>
                {
                    b.Navigation("team_subject");

                    b.Navigation("wish");
                });

            modelBuilder.Entity("backend.Data.Models.Team", b =>
                {
                    b.Navigation("creator_challenge");

                    b.Navigation("target_challenge");

                    b.Navigation("team_subject");

                    b.Navigation("user_team");

                    b.Navigation("wish");
                });

            modelBuilder.Entity("backend.Data.Models.User", b =>
                {
                    b.Navigation("characters");

                    b.Navigation("user_team");
                });
#pragma warning restore 612, 618
        }
    }
}
