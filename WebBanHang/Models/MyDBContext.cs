using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class MyDBContext : DbContext

    {
        public DbSet<Loai> loais { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
       
        public MyDBContext(DbContextOptions<MyDBContext>
       options) : base(options)
        {
        }
    }
}
