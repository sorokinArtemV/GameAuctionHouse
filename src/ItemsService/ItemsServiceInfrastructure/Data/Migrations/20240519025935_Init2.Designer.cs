﻿// <auto-generated />
using System;
using System.Collections.Generic;
using ItemsService.ItemsServiceInfrastructure.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ItemsService.ItemsServiceInfrastructure.Data.Migrations
{
    [DbContext(typeof(ItemsDbContext))]
    [Migration("20240519025935_Init2")]
    partial class Init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemParameters.Effect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ArmorId")
                        .HasColumnType("integer");

                    b.Property<int>("Charges")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<bool>("IsPassive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("WeaponId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ArmorId");

                    b.HasIndex("WeaponId");

                    b.ToTable("Effects");
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemTypes.Armor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ArmorType")
                        .HasColumnType("text");

                    b.Property<int>("ArmorValue")
                        .HasColumnType("integer");

                    b.Property<string>("BoundType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Durability")
                        .HasColumnType("integer");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBound")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsConjured")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLootable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsQuestItem")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsStackable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUnique")
                        .HasColumnType("boolean");

                    b.Property<int>("ItemLevel")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("RequiredClasses")
                        .HasColumnType("text[]");

                    b.Property<int>("RequiredLevel")
                        .HasColumnType("integer");

                    b.Property<List<string>>("RequiredRace")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("RequiredSkill")
                        .HasColumnType("text[]");

                    b.Property<int>("StackSize")
                        .HasColumnType("integer");

                    b.Property<bool>("StartsQuest")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Armors");
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemTypes.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("AttackSpeed")
                        .HasColumnType("double precision");

                    b.Property<string>("BoundType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DamageType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Durability")
                        .HasColumnType("integer");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBound")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsConjured")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsLootable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsMainHand")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOffHand")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsQuestItem")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsStackable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsTwoHanded")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsUnique")
                        .HasColumnType("boolean");

                    b.Property<int>("ItemLevel")
                        .HasColumnType("integer");

                    b.Property<double>("MaxDamage")
                        .HasColumnType("double precision");

                    b.Property<double>("MinDamage")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<string>>("RequiredClasses")
                        .HasColumnType("text[]");

                    b.Property<int>("RequiredLevel")
                        .HasColumnType("integer");

                    b.Property<List<string>>("RequiredRace")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("RequiredSkill")
                        .HasColumnType("text[]");

                    b.Property<int>("StackSize")
                        .HasColumnType("integer");

                    b.Property<bool>("StartsQuest")
                        .HasColumnType("boolean");

                    b.Property<string>("WeaponType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemParameters.Effect", b =>
                {
                    b.HasOne("ItemsService.ItemServiceCore.Entities.ItemTypes.Armor", null)
                        .WithMany("SpecialEffects")
                        .HasForeignKey("ArmorId");

                    b.HasOne("ItemsService.ItemServiceCore.Entities.ItemTypes.Weapon", null)
                        .WithMany("SpecialEffects")
                        .HasForeignKey("WeaponId");
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemTypes.Armor", b =>
                {
                    b.OwnsOne("ItemsService.ItemServiceCore.Entities.ItemParameters.PrimaryStats", "PrimaryStats", b1 =>
                        {
                            b1.Property<int>("ArmorId")
                                .HasColumnType("integer");

                            b1.Property<int?>("Agility")
                                .HasColumnType("integer");

                            b1.Property<int?>("Intellect")
                                .HasColumnType("integer");

                            b1.Property<int?>("Spirit")
                                .HasColumnType("integer");

                            b1.Property<int?>("Stamina")
                                .HasColumnType("integer");

                            b1.Property<int?>("Strength")
                                .HasColumnType("integer");

                            b1.HasKey("ArmorId");

                            b1.ToTable("Armors");

                            b1.WithOwner()
                                .HasForeignKey("ArmorId");
                        });

                    b.OwnsOne("ItemsService.ItemServiceCore.Entities.ItemParameters.SecondaryStats", "SecondaryStats", b1 =>
                        {
                            b1.Property<int>("ArmorId")
                                .HasColumnType("integer");

                            b1.Property<int?>("AttackPower")
                                .HasColumnType("integer");

                            b1.Property<int?>("CriticalStrike")
                                .HasColumnType("integer");

                            b1.Property<int?>("HealingPower")
                                .HasColumnType("integer");

                            b1.Property<int?>("ManaRegenPerSecond")
                                .HasColumnType("integer");

                            b1.Property<int?>("SpellPower")
                                .HasColumnType("integer");

                            b1.HasKey("ArmorId");

                            b1.ToTable("Armors");

                            b1.WithOwner()
                                .HasForeignKey("ArmorId");
                        });

                    b.Navigation("PrimaryStats")
                        .IsRequired();

                    b.Navigation("SecondaryStats")
                        .IsRequired();
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemTypes.Weapon", b =>
                {
                    b.OwnsOne("ItemsService.ItemServiceCore.Entities.ItemParameters.PrimaryStats", "PrimaryStats", b1 =>
                        {
                            b1.Property<int>("WeaponId")
                                .HasColumnType("integer");

                            b1.Property<int?>("Agility")
                                .HasColumnType("integer");

                            b1.Property<int?>("Intellect")
                                .HasColumnType("integer");

                            b1.Property<int?>("Spirit")
                                .HasColumnType("integer");

                            b1.Property<int?>("Stamina")
                                .HasColumnType("integer");

                            b1.Property<int?>("Strength")
                                .HasColumnType("integer");

                            b1.HasKey("WeaponId");

                            b1.ToTable("Weapons");

                            b1.WithOwner()
                                .HasForeignKey("WeaponId");
                        });

                    b.OwnsOne("ItemsService.ItemServiceCore.Entities.ItemParameters.SecondaryStats", "SecondaryStats", b1 =>
                        {
                            b1.Property<int>("WeaponId")
                                .HasColumnType("integer");

                            b1.Property<int?>("AttackPower")
                                .HasColumnType("integer");

                            b1.Property<int?>("CriticalStrike")
                                .HasColumnType("integer");

                            b1.Property<int?>("HealingPower")
                                .HasColumnType("integer");

                            b1.Property<int?>("ManaRegenPerSecond")
                                .HasColumnType("integer");

                            b1.Property<int?>("SpellPower")
                                .HasColumnType("integer");

                            b1.HasKey("WeaponId");

                            b1.ToTable("Weapons");

                            b1.WithOwner()
                                .HasForeignKey("WeaponId");
                        });

                    b.Navigation("PrimaryStats")
                        .IsRequired();

                    b.Navigation("SecondaryStats")
                        .IsRequired();
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemTypes.Armor", b =>
                {
                    b.Navigation("SpecialEffects");
                });

            modelBuilder.Entity("ItemsService.ItemServiceCore.Entities.ItemTypes.Weapon", b =>
                {
                    b.Navigation("SpecialEffects");
                });
#pragma warning restore 612, 618
        }
    }
}
