using Microsoft.EntityFrameworkCore;

namespace E10_Warehouse.Models
{
    public class GoodsContext: DbContext
    {
        public GoodsContext(DbContextOptions<GoodsContext> options)
          : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
        DbSet<Good> Goods { get; set; }
    }
}
