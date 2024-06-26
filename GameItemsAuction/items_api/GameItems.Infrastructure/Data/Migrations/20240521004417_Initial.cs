﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ItemsService.ItemsServiceInfrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArmorType = table.Column<string>(type: "text", nullable: true),
                    ArmorValue = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Quality = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ItemLevel = table.Column<int>(type: "integer", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    IsStackable = table.Column<bool>(type: "boolean", nullable: false),
                    StackSize = table.Column<int>(type: "integer", nullable: false),
                    IsBound = table.Column<bool>(type: "boolean", nullable: false),
                    BoundType = table.Column<string>(type: "text", nullable: false),
                    IsConjured = table.Column<bool>(type: "boolean", nullable: false),
                    IsUnique = table.Column<bool>(type: "boolean", nullable: false),
                    Durability = table.Column<int>(type: "integer", nullable: false),
                    IsQuestItem = table.Column<bool>(type: "boolean", nullable: false),
                    StartsQuest = table.Column<bool>(type: "boolean", nullable: false),
                    RequiredRace = table.Column<List<string>>(type: "text[]", nullable: true),
                    RequiredClasses = table.Column<List<string>>(type: "text[]", nullable: true),
                    RequiredLevel = table.Column<int>(type: "integer", nullable: false),
                    RequiredSkill = table.Column<List<string>>(type: "text[]", nullable: true),
                    IsLocked = table.Column<bool>(type: "boolean", nullable: false),
                    IsLootable = table.Column<bool>(type: "boolean", nullable: false),
                    PrimaryStats_Strength = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Agility = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Stamina = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Intellect = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Spirit = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_CriticalStrike = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_AttackPower = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_SpellPower = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_HealingPower = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_ManaRegenPerSecond = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponType = table.Column<string>(type: "text", nullable: false),
                    DamageType = table.Column<string>(type: "text", nullable: false),
                    MinDamage = table.Column<double>(type: "double precision", nullable: false),
                    MaxDamage = table.Column<double>(type: "double precision", nullable: false),
                    AttackSpeed = table.Column<double>(type: "double precision", nullable: false),
                    IsTwoHanded = table.Column<bool>(type: "boolean", nullable: false),
                    IsMainHand = table.Column<bool>(type: "boolean", nullable: false),
                    IsOffHand = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Quality = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ItemLevel = table.Column<int>(type: "integer", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    IsStackable = table.Column<bool>(type: "boolean", nullable: false),
                    StackSize = table.Column<int>(type: "integer", nullable: false),
                    IsBound = table.Column<bool>(type: "boolean", nullable: false),
                    BoundType = table.Column<string>(type: "text", nullable: false),
                    IsConjured = table.Column<bool>(type: "boolean", nullable: false),
                    IsUnique = table.Column<bool>(type: "boolean", nullable: false),
                    Durability = table.Column<int>(type: "integer", nullable: false),
                    IsQuestItem = table.Column<bool>(type: "boolean", nullable: false),
                    StartsQuest = table.Column<bool>(type: "boolean", nullable: false),
                    RequiredRace = table.Column<List<string>>(type: "text[]", nullable: true),
                    RequiredClasses = table.Column<List<string>>(type: "text[]", nullable: true),
                    RequiredLevel = table.Column<int>(type: "integer", nullable: false),
                    RequiredSkill = table.Column<List<string>>(type: "text[]", nullable: true),
                    IsLocked = table.Column<bool>(type: "boolean", nullable: false),
                    IsLootable = table.Column<bool>(type: "boolean", nullable: false),
                    PrimaryStats_Strength = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Agility = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Stamina = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Intellect = table.Column<int>(type: "integer", nullable: true),
                    PrimaryStats_Spirit = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_CriticalStrike = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_AttackPower = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_SpellPower = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_HealingPower = table.Column<int>(type: "integer", nullable: true),
                    SecondaryStats_ManaRegenPerSecond = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArmorEffect",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArmorId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Charges = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: false),
                    IsPassive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEffect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArmorEffect_Armors_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WeaponEffects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeaponId = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Charges = table.Column<int>(type: "integer", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "interval", nullable: false),
                    IsPassive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponEffects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeaponEffects_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEffect_ArmorId",
                table: "ArmorEffect",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponEffects_WeaponId",
                table: "WeaponEffects",
                column: "WeaponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorEffect");

            migrationBuilder.DropTable(
                name: "WeaponEffects");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}
