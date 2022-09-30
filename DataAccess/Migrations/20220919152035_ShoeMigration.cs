using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class ShoeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarkaClassics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaClassics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarkaDiscounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaDiscounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarkaSports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaSports", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarkaStyles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkaStyles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Reklams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reklams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SizeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhatsappURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelegramURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GithubURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShoeClassics",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    MarkaClassicID = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeClassics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoeClassics_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeClassics_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeClassics_MarkaClassics_MarkaClassicID",
                        column: x => x.MarkaClassicID,
                        principalTable: "MarkaClassics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeClassics_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoeDiscounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    MarkaDiscountID = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeDiscounts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoeDiscounts_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeDiscounts_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeDiscounts_MarkaDiscounts_MarkaDiscountID",
                        column: x => x.MarkaDiscountID,
                        principalTable: "MarkaDiscounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeDiscounts_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoeSports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    MarkaSportID = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeSports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoeSports_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeSports_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeSports_MarkaSports_MarkaSportID",
                        column: x => x.MarkaSportID,
                        principalTable: "MarkaSports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeSports_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoeStyles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    MarkaStyleID = table.Column<int>(type: "int", nullable: false),
                    ColorID = table.Column<int>(type: "int", nullable: false),
                    SizeID = table.Column<int>(type: "int", nullable: false),
                    CurrencyID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoeStyles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoeStyles_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeStyles_Currencies_CurrencyID",
                        column: x => x.CurrencyID,
                        principalTable: "Currencies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeStyles_MarkaStyles_MarkaStyleID",
                        column: x => x.MarkaStyleID,
                        principalTable: "MarkaStyles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoeStyles_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoeClassics_ColorID",
                table: "ShoeClassics",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeClassics_CurrencyID",
                table: "ShoeClassics",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeClassics_MarkaClassicID",
                table: "ShoeClassics",
                column: "MarkaClassicID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeClassics_SizeID",
                table: "ShoeClassics",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeDiscounts_ColorID",
                table: "ShoeDiscounts",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeDiscounts_CurrencyID",
                table: "ShoeDiscounts",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeDiscounts_MarkaDiscountID",
                table: "ShoeDiscounts",
                column: "MarkaDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeDiscounts_SizeID",
                table: "ShoeDiscounts",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeSports_ColorID",
                table: "ShoeSports",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeSports_CurrencyID",
                table: "ShoeSports",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeSports_MarkaSportID",
                table: "ShoeSports",
                column: "MarkaSportID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeSports_SizeID",
                table: "ShoeSports",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeStyles_ColorID",
                table: "ShoeStyles",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeStyles_CurrencyID",
                table: "ShoeStyles",
                column: "CurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeStyles_MarkaStyleID",
                table: "ShoeStyles",
                column: "MarkaStyleID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoeStyles_SizeID",
                table: "ShoeStyles",
                column: "SizeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Reklams");

            migrationBuilder.DropTable(
                name: "ShoeClassics");

            migrationBuilder.DropTable(
                name: "ShoeDiscounts");

            migrationBuilder.DropTable(
                name: "ShoeSports");

            migrationBuilder.DropTable(
                name: "ShoeStyles");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "MarkaClassics");

            migrationBuilder.DropTable(
                name: "MarkaDiscounts");

            migrationBuilder.DropTable(
                name: "MarkaSports");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "MarkaStyles");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
