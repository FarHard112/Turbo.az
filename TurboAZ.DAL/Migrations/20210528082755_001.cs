using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TurboAZ.DAL.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bodies",
                columns: table => new
                {
                    BodyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BodyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodies", x => x.BodyId);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "EngineVolumes",
                columns: table => new
                {
                    EngineVolumeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EngineVolumeName = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineVolumes", x => x.EngineVolumeId);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    FuelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.FuelId);
                });

            migrationBuilder.CreateTable(
                name: "GearBoxes",
                columns: table => new
                {
                    GearBoxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GearBoxName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBoxes", x => x.GearBoxId);
                });

            migrationBuilder.CreateTable(
                name: "ImageTypes",
                columns: table => new
                {
                    ImageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageTypes", x => x.ImageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    TransmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransmissionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.TransmissionId);
                });

            migrationBuilder.CreateTable(
                name: "Valutes",
                columns: table => new
                {
                    ValuteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValuteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valutes", x => x.ValuteId);
                });

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    YearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.YearId);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ModelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ModelId);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    AdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    BodyId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ValuteId = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    GearBoxId = table.Column<int>(type: "int", nullable: false),
                    EngineVolumeId = table.Column<int>(type: "int", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Hp = table.Column<int>(type: "int", nullable: false),
                    Walk = table.Column<int>(type: "int", nullable: false),
                    CreditHave = table.Column<bool>(type: "bit", nullable: false),
                    Barter = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlloyWheels = table.Column<bool>(type: "bit", nullable: false),
                    CentralClosure = table.Column<bool>(type: "bit", nullable: false),
                    LeatherSalon = table.Column<bool>(type: "bit", nullable: false),
                    SeatVent = table.Column<bool>(type: "bit", nullable: false),
                    Abs = table.Column<bool>(type: "bit", nullable: false),
                    ParkRadar = table.Column<bool>(type: "bit", nullable: false),
                    XenonLamps = table.Column<bool>(type: "bit", nullable: false),
                    Lyuk = table.Column<bool>(type: "bit", nullable: false),
                    Conditioner = table.Column<bool>(type: "bit", nullable: false),
                    RearCamera = table.Column<bool>(type: "bit", nullable: false),
                    RainSensor = table.Column<bool>(type: "bit", nullable: false),
                    SeatHeating = table.Column<bool>(type: "bit", nullable: false),
                    SideCurtains = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.AdId);
                    table.ForeignKey(
                        name: "FK_Ads_Bodies_BodyId",
                        column: x => x.BodyId,
                        principalTable: "Bodies",
                        principalColumn: "BodyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_EngineVolumes_EngineVolumeId",
                        column: x => x.EngineVolumeId,
                        principalTable: "EngineVolumes",
                        principalColumn: "EngineVolumeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "FuelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_GearBoxes_GearBoxId",
                        column: x => x.GearBoxId,
                        principalTable: "GearBoxes",
                        principalColumn: "GearBoxId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "TransmissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Valutes_ValuteId",
                        column: x => x.ValuteId,
                        principalTable: "Valutes",
                        principalColumn: "ValuteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ads_Years_YearId",
                        column: x => x.YearId,
                        principalTable: "Years",
                        principalColumn: "YearId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageTypeId = table.Column<int>(type: "int", nullable: false),
                    AdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Ads_AdId",
                        column: x => x.AdId,
                        principalTable: "Ads",
                        principalColumn: "AdId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Images_ImageTypes_ImageTypeId",
                        column: x => x.ImageTypeId,
                        principalTable: "ImageTypes",
                        principalColumn: "ImageTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ads_BodyId",
                table: "Ads",
                column: "BodyId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_BrandId",
                table: "Ads",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_CityId",
                table: "Ads",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_ColorId",
                table: "Ads",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_EngineVolumeId",
                table: "Ads",
                column: "EngineVolumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_FuelId",
                table: "Ads",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_GearBoxId",
                table: "Ads",
                column: "GearBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_ModelId",
                table: "Ads",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_TransmissionId",
                table: "Ads",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_ValuteId",
                table: "Ads",
                column: "ValuteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_YearId",
                table: "Ads",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_AdId",
                table: "Images",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ImageTypeId",
                table: "Images",
                column: "ImageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Ads");

            migrationBuilder.DropTable(
                name: "ImageTypes");

            migrationBuilder.DropTable(
                name: "Bodies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "EngineVolumes");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "GearBoxes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "Valutes");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
