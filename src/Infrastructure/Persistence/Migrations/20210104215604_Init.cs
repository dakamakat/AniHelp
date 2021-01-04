using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersistenceMigrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: true),
                    SelfLink = table.Column<string>(type: "nvarchar(127)", maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "date", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    EndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Synopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImageTopOffset = table.Column<int>(type: "int", nullable: false),
                    CanonicalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCount = table.Column<int>(type: "int", nullable: false),
                    FavoritesCount = table.Column<int>(type: "int", nullable: false),
                    NextRelease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PopularityRank = table.Column<int>(type: "int", nullable: false),
                    RatingRank = table.Column<int>(type: "int", nullable: false),
                    AgeRatingGuide = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tba = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpisodeCount = table.Column<int>(type: "int", nullable: false),
                    EpisodeLength = table.Column<int>(type: "int", nullable: false),
                    TotalLength = table.Column<int>(type: "int", nullable: false),
                    YoutubeVideoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nsfw = table.Column<bool>(type: "bit", nullable: false),
                    AbbreviatedTitles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeRating = table.Column<int>(type: "int", nullable: false),
                    ShowType = table.Column<int>(type: "int", nullable: false),
                    Titles_En = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titles_En_jp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titles_Ja_jp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titles_En_us = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attributes_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Self = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Related = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Animes_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Animes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Tiny = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Small = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Large = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Original = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttributesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatingFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Two = table.Column<int>(type: "int", nullable: false),
                    Three = table.Column<int>(type: "int", nullable: false),
                    Four = table.Column<int>(type: "int", nullable: false),
                    Five = table.Column<int>(type: "int", nullable: false),
                    Six = table.Column<int>(type: "int", nullable: false),
                    Seven = table.Column<int>(type: "int", nullable: false),
                    Eeight = table.Column<int>(type: "int", nullable: false),
                    Nine = table.Column<int>(type: "int", nullable: false),
                    Ten = table.Column<int>(type: "int", nullable: false),
                    Eleven = table.Column<int>(type: "int", nullable: false),
                    Twelwe = table.Column<int>(type: "int", nullable: false),
                    Thirteen = table.Column<int>(type: "int", nullable: false),
                    Fourteen = table.Column<int>(type: "int", nullable: false),
                    Fifteen = table.Column<int>(type: "int", nullable: false),
                    Sixteen = table.Column<int>(type: "int", nullable: false),
                    Seventeen = table.Column<int>(type: "int", nullable: false),
                    Eighteen = table.Column<int>(type: "int", nullable: false),
                    Nineteen = table.Column<int>(type: "int", nullable: false),
                    Twenty = table.Column<int>(type: "int", nullable: false),
                    AttributesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatingFrequencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RatingFrequencies_Attributes_AttributesId",
                        column: x => x.AttributesId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_AnimeId",
                table: "Attributes",
                column: "AnimeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_AttributesId",
                table: "Images",
                column: "AttributesId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_AnimeId",
                table: "Links",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_RatingFrequencies_AttributesId",
                table: "RatingFrequencies",
                column: "AttributesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_ImageId",
                table: "Sizes",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "RatingFrequencies");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Animes");
        }
    }
}
