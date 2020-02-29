using Youtube.Api.Domain.Entities;

namespace Youtube.Api.Infrastructure.EntityConfig
{
    public class ConteudoConfig : EntityTypeConfiguration<Conteudo>
    {
        public CConteudoConfig()
        {
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
