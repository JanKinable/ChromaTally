using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChromaTally.Site.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    BCMPortionUnit = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BCMPortionValue = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<int>(type: "int", nullable: false),
                    Fat = table.Column<int>(type: "int", nullable: false),
                    Fibers = table.Column<int>(type: "int", nullable: false),
                    Energy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nutrition");
        }
    }
}
