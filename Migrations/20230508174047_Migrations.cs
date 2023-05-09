using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_PIV_BazaDanych_ESIT.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfertyTurystyczne",
                columns: table => new
                {
                    ID_Oferty_Turystycznej = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kategoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Koszt = table.Column<int>(type: "int", nullable: false),
                    DataWyjazdu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataPrzyjazdu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MiejsceWyjazdu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiejsceDocelowe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfertyTurystyczne", x => x.ID_Oferty_Turystycznej);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownicy",
                columns: table => new
                {
                    ID_Użytkownika = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUrodzenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownicy", x => x.ID_Użytkownika);
                });

            migrationBuilder.CreateTable(
                name: "Opinie",
                columns: table => new
                {
                    ID_Opini = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataWystawienia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ocena = table.Column<int>(type: "int", nullable: false),
                    OfertaTurystycznaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opinie", x => x.ID_Opini);
                    table.ForeignKey(
                        name: "FK_Opinie_OfertyTurystyczne_OfertaTurystycznaID",
                        column: x => x.OfertaTurystycznaID,
                        principalTable: "OfertyTurystyczne",
                        principalColumn: "ID_Oferty_Turystycznej",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezerwacje",
                columns: table => new
                {
                    ID_Rezerwacji = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRezerwacji = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LiczbaOsób = table.Column<int>(type: "int", nullable: false),
                    Koszt = table.Column<int>(type: "int", nullable: false),
                    OfertaTurystycznaID = table.Column<int>(type: "int", nullable: false),
                    UżytkownicyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezerwacje", x => x.ID_Rezerwacji);
                    table.ForeignKey(
                        name: "FK_Rezerwacje_OfertyTurystyczne_OfertaTurystycznaID",
                        column: x => x.OfertaTurystycznaID,
                        principalTable: "OfertyTurystyczne",
                        principalColumn: "ID_Oferty_Turystycznej",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezerwacje_Użytkownicy_UżytkownicyID",
                        column: x => x.UżytkownicyID,
                        principalTable: "Użytkownicy",
                        principalColumn: "ID_Użytkownika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wiadomości",
                columns: table => new
                {
                    ID_Wiadomości = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RezerwacjaID = table.Column<int>(type: "int", nullable: false),
                    UżytkownicyID = table.Column<int>(type: "int", nullable: false),
                    UżytkownicyID1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wiadomości", x => x.ID_Wiadomości);
                    table.ForeignKey(
                        name: "FK_Wiadomości_Rezerwacje_RezerwacjaID",
                        column: x => x.RezerwacjaID,
                        principalTable: "Rezerwacje",
                        principalColumn: "ID_Rezerwacji",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wiadomości_Użytkownicy_UżytkownicyID",
                        column: x => x.UżytkownicyID,
                        principalTable: "Użytkownicy",
                        principalColumn: "ID_Użytkownika",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wiadomości_Użytkownicy_UżytkownicyID1",
                        column: x => x.UżytkownicyID1,
                        principalTable: "Użytkownicy",
                        principalColumn: "ID_Użytkownika");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Opinie_OfertaTurystycznaID",
                table: "Opinie",
                column: "OfertaTurystycznaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_OfertaTurystycznaID",
                table: "Rezerwacje",
                column: "OfertaTurystycznaID");

            migrationBuilder.CreateIndex(
                name: "IX_Rezerwacje_UżytkownicyID",
                table: "Rezerwacje",
                column: "UżytkownicyID");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomości_RezerwacjaID",
                table: "Wiadomości",
                column: "RezerwacjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomości_UżytkownicyID",
                table: "Wiadomości",
                column: "UżytkownicyID");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomości_UżytkownicyID1",
                table: "Wiadomości",
                column: "UżytkownicyID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opinie");

            migrationBuilder.DropTable(
                name: "Wiadomości");

            migrationBuilder.DropTable(
                name: "Rezerwacje");

            migrationBuilder.DropTable(
                name: "OfertyTurystyczne");

            migrationBuilder.DropTable(
                name: "Użytkownicy");
        }
    }
}
