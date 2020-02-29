using Microsoft.EntityFrameworkCore;
using Youtube.Api.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using Youtube.Api.Infrastructure.EntityConfig;

namespace Youtube.Api.Infrastructure.Context
{
    public class YoutubeContext : DbContext
    {
        public YoutubeContext(DbContextOptions<YoutubeContext> options) : base(options)
        {

        }

        public virtual DbSet<Conteudo> Conteudos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConteudoConfig());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.Relational().TableName = entityType.DisplayName();

                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }
        }
    }
}
