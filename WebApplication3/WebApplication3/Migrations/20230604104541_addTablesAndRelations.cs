using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    public partial class addTablesAndRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChefProfessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChefProfessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FbUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TwitterUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestemonialProfessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestemonialProfessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChefProfessionId = table.Column<int>(type: "int", nullable: false),
                    ChefSocialMediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chefs_ChefProfessions_ChefProfessionId",
                        column: x => x.ChefProfessionId,
                        principalTable: "ChefProfessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chefs_SocialMedias_ChefSocialMediaId",
                        column: x => x.ChefSocialMediaId,
                        principalTable: "SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestemonialProfessionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Testimonials_TestemonialProfessions_TestemonialProfessionId",
                        column: x => x.TestemonialProfessionId,
                        principalTable: "TestemonialProfessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_ChefProfessionId",
                table: "Chefs",
                column: "ChefProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_ChefSocialMediaId",
                table: "Chefs",
                column: "ChefSocialMediaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_TestemonialProfessionId",
                table: "Testimonials",
                column: "TestemonialProfessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chefs");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "ChefProfessions");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "TestemonialProfessions");
        }
    }
}
