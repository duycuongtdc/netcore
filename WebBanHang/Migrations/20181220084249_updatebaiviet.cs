using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBanHang.Migrations
{
    public partial class updatebaiviet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hinh",
                table: "BaiViet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TieuDe",
                table: "BaiViet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hinh",
                table: "BaiViet");

            migrationBuilder.DropColumn(
                name: "TieuDe",
                table: "BaiViet");
        }
    }
}
