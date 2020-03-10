using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool EhAdministrador { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int GrupoId { get; set; }
        public virtual Grupo Grupo { get; set; }

        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            builder.HasKey(p => new { p.UsuarioId, p.GrupoId});

            builder.Property(p => p.DataCriacao)
                    .IsRequired();

            builder.Property(p => p.EhAdministrador)
                    .IsRequired();            
        }
    }
}
