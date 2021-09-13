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

            migrationBuilder.InsertData(
                table: "tblPayment",
                columns: new[] { "id", "UsersModelid", "amount", "date", "status", "userid" },
                values: new object[,]
                {
                    { 1, null, "1500.00", "9/1/2021", "OK", 1 },
                    { 2, null, "2500.00", "9/2/2021", "OK", 1 },
                    { 3, null, "3500.00", "9/3/2021", "OK", 1 },
                    { 4, null, "5460.00", "8/24/2021", "CLOSED", 2 },
                    { 5, null, "600.00", "7/1/2021", "OK", 2 }
                });

            migrationBuilder.InsertData(
                table: "tblUser",
                columns: new[] { "id", "accountBalance" },
                values: new object[,]
                {
                    { 1, "30000.00" },
                    { 2, "50000.00" }
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
