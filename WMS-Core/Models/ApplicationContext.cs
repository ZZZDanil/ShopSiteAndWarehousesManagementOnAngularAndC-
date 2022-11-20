using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace WMS_Core.Models
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<ItemModel> ItemModels{ get; set; }
        public virtual DbSet<ItemTypeModel> ItemTypeModels { get; set; }
        public virtual DbSet<WarehouseModel> WarehouseModels { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
