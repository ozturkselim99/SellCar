using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sellcar.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iller",
                columns: table => new
                {
                    ilId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    adi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iller", x => x.ilId);
                });

            migrationBuilder.CreateTable(
                name: "Markalar",
                columns: table => new
                {
                    MarkaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    adi = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markalar", x => x.MarkaId);
                });

            migrationBuilder.CreateTable(
                name: "Ilanlar",
                columns: table => new
                {
                    IlanId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ilanBasligi = table.Column<string>(nullable: true),
                    ilanDetay = table.Column<string>(nullable: true),
                    ilanTarihi = table.Column<DateTime>(nullable: false),
                    seri = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    yil = table.Column<int>(nullable: false),
                    yakitTipi = table.Column<string>(nullable: true),
                    vitesTipi = table.Column<string>(nullable: true),
                    vitesSayisi = table.Column<int>(nullable: false),
                    kilometre = table.Column<int>(nullable: false),
                    kasaTipi = table.Column<string>(nullable: true),
                    kapiSayisi = table.Column<int>(nullable: false),
                    motorGücü = table.Column<int>(nullable: false),
                    motorHacmi = table.Column<int>(nullable: false),
                    azamiSurati = table.Column<int>(nullable: false),
                    hizlanma = table.Column<double>(nullable: false),
                    cekisTipi = table.Column<string>(nullable: true),
                    sehirIciTuketim = table.Column<double>(nullable: false),
                    sehirDisiTuketim = table.Column<double>(nullable: false),
                    ortalamaTuketim = table.Column<double>(nullable: false),
                    yakitDepoHacmi = table.Column<int>(nullable: false),
                    renk = table.Column<string>(nullable: true),
                    kimden = table.Column<string>(nullable: true),
                    takas = table.Column<string>(nullable: true),
                    durum = table.Column<string>(nullable: true),
                    anasayfa = table.Column<bool>(nullable: false),
                    fiyat = table.Column<double>(nullable: false),
                    userId = table.Column<string>(nullable: true),
                    ilId = table.Column<int>(nullable: false),
                    markaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilanlar", x => x.IlanId);
                    table.ForeignKey(
                        name: "FK_Ilanlar_Iller_ilId",
                        column: x => x.ilId,
                        principalTable: "Iller",
                        principalColumn: "ilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ilanlar_Markalar_markaId",
                        column: x => x.markaId,
                        principalTable: "Markalar",
                        principalColumn: "MarkaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: true),
                    IlanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favs_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "IlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resimler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    url = table.Column<string>(nullable: true),
                    IlanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resimler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resimler_Ilanlar_IlanId",
                        column: x => x.IlanId,
                        principalTable: "Ilanlar",
                        principalColumn: "IlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favs_IlanId",
                table: "Favs",
                column: "IlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_ilId",
                table: "Ilanlar",
                column: "ilId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilanlar_markaId",
                table: "Ilanlar",
                column: "markaId");

            migrationBuilder.CreateIndex(
                name: "IX_Resimler_IlanId",
                table: "Resimler",
                column: "IlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favs");

            migrationBuilder.DropTable(
                name: "Resimler");

            migrationBuilder.DropTable(
                name: "Ilanlar");

            migrationBuilder.DropTable(
                name: "Iller");

            migrationBuilder.DropTable(
                name: "Markalar");
        }
    }
}
