using ApiYoutube.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiYoutube.Models.EntityMap
{
    public class CanalMap : IEntityTypeConfiguration<Canal>
    {
        public void Configure(EntityTypeBuilder<Canal> builder)
        {
            builder.HasKey(p => p.IdCanal);

            builder
                .Property(p => p.NomeCanal)
                .IsRequired()
                .HasMaxLength(150);
            builder
                .Property(p => p.DescricaoCanal)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
