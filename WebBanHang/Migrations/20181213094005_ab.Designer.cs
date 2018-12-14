﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBanHang.Models;

namespace WebBanHang.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20181213094005_ab")]
    partial class ab
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebBanHang.Models.HangHoa", b =>
                {
                    b.Property<int>("MaHH")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DonGia");

                    b.Property<string>("Hinh");

                    b.Property<int>("MaLoai");

                    b.Property<string>("MoTa");

                    b.Property<int>("SoLuong");

                    b.Property<string>("TenHH")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaHH");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("WebBanHang.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("WebBanHang.Models.TaiKhoan", b =>
                {
                    b.Property<string>("MaTK")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MatKhau");

                    b.Property<string>("TenDangNhap");

                    b.HasKey("MaTK");

                    b.ToTable("TaiKhoan");
                });

            modelBuilder.Entity("WebBanHang.Models.HangHoa", b =>
                {
                    b.HasOne("WebBanHang.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
