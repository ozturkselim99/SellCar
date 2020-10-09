using Microsoft.EntityFrameworkCore;
using sellcar.entity;

namespace sellcar.data.Concrete.EfCore
{
    public class SellCarContext: DbContext
    {
        public DbSet<Ilan> Ilanlar { get; set; }
        public DbSet<Resim> Resimler { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Fav> Favs { get; set; }
        public DbSet<Il> Iller { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db");
        }
    }
}
