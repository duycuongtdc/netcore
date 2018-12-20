using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class addbv : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaiViet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoiDung = table.Column<string>(nullable: true),
                    MaLoai = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiViet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuangCao",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hinh = table.Column<string>(nullable: true),
                    MaHH = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuangCao", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OderDetail_OderID",
                table: "OderDetail",
                column: "OderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OderDetail_Oder_OderID",
                table: "OderDetail",
                column: "OderID",
                principalTable: "Oder",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OderDetail_Oder_OderID",
                table: "OderDetail");

            migrationBuilder.DropTable(
                name: "BaiViet");

            migrationBuilder.DropTable(
                name: "QuangCao");

            migrationBuilder.DropIndex(
                name: "IX_OderDetail_OderID",
                table: "OderDetail");
        }
    }
}
