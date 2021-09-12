using Microsoft.EntityFrameworkCore.Migrations;

namespace HTTPApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblUser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountBalance = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUser", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblPayment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userid = table.Column<int>(type: "int", nullable: false),
                    UsersModelid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPayment", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblPayment_tblUser_UsersModelid",
                        column: x => x.UsersModelid,
                        principalTable: "tblUser",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPayment_UsersModelid",
                table: "tblPayment",
                column: "UsersModelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPayment");

            migrationBuilder.DropTable(
                name: "tblUser");
        }
    }
}
