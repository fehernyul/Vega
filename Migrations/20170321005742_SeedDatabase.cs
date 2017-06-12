using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vega.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Opel')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Suzuki')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Volkswagen')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Corsa', (SELECT ID FROM Makes WHERE Name = 'Opel'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Astra', (SELECT ID FROM Makes WHERE Name = 'Opel'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Insignia', (SELECT ID FROM Makes WHERE Name = 'Opel'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Ignis', (SELECT ID FROM Makes WHERE Name = 'Suzuki'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Vitara', (SELECT ID FROM Makes WHERE Name = 'Suzuki'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Shift', (SELECT ID FROM Makes WHERE Name = 'Suzuki  '))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Polo', (SELECT ID FROM Makes WHERE Name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Passat', (SELECT ID FROM Makes WHERE Name = 'Volkswagen'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Golf', (SELECT ID FROM Makes WHERE Name = 'Volkswagen'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Opel', 'Suzuki', 'Volkswagen')");
        }
    }
}
