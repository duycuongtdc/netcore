using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Models;

namespace WebBanHang.Models
{
    public class MyDBContext : DbContext

    {
        public DbSet<Loai> loais { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Oder> Oders { get; set; }
        public DbSet<OderDetail> OderDetails { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext>
       options) : base(options)
        {
        }

        public DbSet<WebBanHang.Models.BaiViet> BaiViet { get; set; }

        public DbSet<WebBanHang.Models.QuangCao> QuangCao { get; set; }
    }
}
