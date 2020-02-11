using ApiYoutube.Models.Entity;
using ApiYoutube.Models.EntityMap;
using Microsoft.EntityFrameworkCore;

namespace ApiYoutube.Context
{
    public class ApiYoutubeContext : DbContext
    {
        public ApiYoutubeContext(DbContextOptions<ApiYoutubeContext> options) : base(options)
        {

        }

        public virtual DbSet<Canal> Canal { get; set; }
        public virtual DbSet<CanalItem> CanalItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CanalMap());
            modelBuilder.ApplyConfiguration(new CanalItemMap());
        }
    }
}
