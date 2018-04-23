using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MistrzowieWynajmu.Migrations
{
    public partial class SeedingDB : Migration
    {
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Tomasz','Kempa','669202185')");
			migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Andrzej','Kawka','995345621')");
			migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Krzysztof','Biedroń','642815523')");
			migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Horacy','Idol','773991632')");

			migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Lwowska','Rzeszów')");
			migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Podzamcze','Narol')");
			migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('3maja','Orzeszków')");
			migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Narutowicza','Lublin')");

			migrationBuilder.Sql("INSERT INTO Properties (Type, Descryption, Rooms, Area, Washer, Referigerator, Iron, AddressId, OwnerId) VALUES (0, 'opis1', 140, 7,1,1,0,1,1)");
			migrationBuilder.Sql("INSERT INTO Properties (Type, Descryption, Rooms, Area, Washer, Referigerator, Iron, AddressId, OwnerId) VALUES (1, 'opis2', 70, 1,1,1,1,2,2)");
			migrationBuilder.Sql("INSERT INTO Properties (Type, Descryption, Rooms, Area, Washer, Referigerator, Iron, AddressId, OwnerId) VALUES (0, 'opis3', 190,5,1,0,1,3,3)");
			migrationBuilder.Sql("INSERT INTO Properties (Type, Descryption, Rooms, Area, Washer, Referigerator, Iron, AddressId, OwnerId) VALUES (1, 'opis3', 50,2,0,1,1,4,4)");

		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.Sql("DELETE FROM Owners");
			migrationBuilder.Sql("DELETE FROM Address");
			migrationBuilder.Sql("DELETE FROM Propertys");

		}
	}
}
