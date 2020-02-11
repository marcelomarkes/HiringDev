using ApiYoutube.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiYoutube.Models.EntityMap
{
    public class CanalItemMap : IEntityTypeConfiguration<CanalItem>
    {
        public void Configure(EntityTypeBuilder<CanalItem> builder)
        {
            builder.HasKey(p => p.IdCanalItem);

            builder
                .Property(p => p.NomeCanalItem)
                .IsRequired()
                .HasMaxLength(150);
            builder
                .Property(p => p.ComentarioCanalItem)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
