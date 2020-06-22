using Microsoft.EntityFrameworkCore.Migrations;

namespace ApdbTest2.Migrations
{
    public partial class Next4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Manufacturers_IdManufactureDict",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Cities_IdCityDict",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Cars_IdCar",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Clients_IdClient",
                table: "Rents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rents",
                table: "Rents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cars",
                table: "Cars");

            migrationBuilder.RenameTable(
                name: "Rents",
                newName: "RentTest");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "ManufacturerTest");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "ClientTest");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "CityTest");

            migrationBuilder.RenameTable(
                name: "Cars",
                newName: "CarTest");

            migrationBuilder.RenameIndex(
                name: "IX_Rents_IdClient",
                table: "RentTest",
                newName: "IX_RentTest_IdClient");

            migrationBuilder.RenameIndex(
                name: "IX_Rents_IdCar",
                table: "RentTest",
                newName: "IX_RentTest_IdCar");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_IdCityDict",
                table: "ClientTest",
                newName: "IX_ClientTest_IdCityDict");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_IdManufactureDict",
                table: "CarTest",
                newName: "IX_CarTest_IdManufactureDict");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RentTest",
                table: "RentTest",
                column: "IdRent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManufacturerTest",
                table: "ManufacturerTest",
                column: "IdManufacturer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClientTest",
                table: "ClientTest",
                column: "IdClient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CityTest",
                table: "CityTest",
                column: "IdCity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarTest",
                table: "CarTest",
                column: "IdCar");

            migrationBuilder.AddForeignKey(
                name: "FK_CarTest_ManufacturerTest_IdManufactureDict",
                table: "CarTest",
                column: "IdManufactureDict",
                principalTable: "ManufacturerTest",
                principalColumn: "IdManufacturer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientTest_CityTest_IdCityDict",
                table: "ClientTest",
                column: "IdCityDict",
                principalTable: "CityTest",
                principalColumn: "IdCity",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentTest_CarTest_IdCar",
                table: "RentTest",
                column: "IdCar",
                principalTable: "CarTest",
                principalColumn: "IdCar",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentTest_ClientTest_IdClient",
                table: "RentTest",
                column: "IdClient",
                principalTable: "ClientTest",
                principalColumn: "IdClient",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarTest_ManufacturerTest_IdManufactureDict",
                table: "CarTest");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientTest_CityTest_IdCityDict",
                table: "ClientTest");

            migrationBuilder.DropForeignKey(
                name: "FK_RentTest_CarTest_IdCar",
                table: "RentTest");

            migrationBuilder.DropForeignKey(
                name: "FK_RentTest_ClientTest_IdClient",
                table: "RentTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RentTest",
                table: "RentTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManufacturerTest",
                table: "ManufacturerTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClientTest",
                table: "ClientTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CityTest",
                table: "CityTest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarTest",
                table: "CarTest");

            migrationBuilder.RenameTable(
                name: "RentTest",
                newName: "Rents");

            migrationBuilder.RenameTable(
                name: "ManufacturerTest",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "ClientTest",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "CityTest",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "CarTest",
                newName: "Cars");

            migrationBuilder.RenameIndex(
                name: "IX_RentTest_IdClient",
                table: "Rents",
                newName: "IX_Rents_IdClient");

            migrationBuilder.RenameIndex(
                name: "IX_RentTest_IdCar",
                table: "Rents",
                newName: "IX_Rents_IdCar");

            migrationBuilder.RenameIndex(
                name: "IX_ClientTest_IdCityDict",
                table: "Clients",
                newName: "IX_Clients_IdCityDict");

            migrationBuilder.RenameIndex(
                name: "IX_CarTest_IdManufactureDict",
                table: "Cars",
                newName: "IX_Cars_IdManufactureDict");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rents",
                table: "Rents",
                column: "IdRent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "IdManufacturer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "IdClient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "IdCity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cars",
                table: "Cars",
                column: "IdCar");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Manufacturers_IdManufactureDict",
                table: "Cars",
                column: "IdManufactureDict",
                principalTable: "Manufacturers",
                principalColumn: "IdManufacturer",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Cities_IdCityDict",
                table: "Clients",
                column: "IdCityDict",
                principalTable: "Cities",
                principalColumn: "IdCity",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Cars_IdCar",
                table: "Rents",
                column: "IdCar",
                principalTable: "Cars",
                principalColumn: "IdCar",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Clients_IdClient",
                table: "Rents",
                column: "IdClient",
                principalTable: "Clients",
                principalColumn: "IdClient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
