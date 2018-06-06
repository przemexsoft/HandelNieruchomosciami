using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HandelNieruchomosciami.Migrations
{
    public partial class SeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Wlasciciels (WlascicielImie, WlascicielNazwisko, WlascicielAdres, WlascicielTelefon, WlascicielEmail) VALUES " +
                "('Siemas','Ziomal','Adress jakis','657576575','siemas@gmail.com')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete * From Wlasciciels");
        }
    }
}
