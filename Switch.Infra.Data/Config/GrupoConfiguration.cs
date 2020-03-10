using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Switch.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Switch.Infra.Data.Config
{
    class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public virtual ICollection<Postagem> Postagens { get; set; }

        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Nome)
                    .IsRequired()
                    .HasMaxLength(30);

            builder.Property(p => p.Descricao)
                    .IsRequired()
                    .HasMaxLength(100);

            builder.Property(p => p.UrlFoto)
                    .IsRequired();

            builder.HasMany(p => p.Postagens).WithOne(x => x.Grupo);

        }
    }
}
