using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3Calidad_N00024035.Models.Map
{
   
    public class CompartirMap : IEntityTypeConfiguration<Compartir>
    {
        public void Configure(EntityTypeBuilder<Compartir> builder)
        {
            builder.ToTable("Compartir");
            builder.HasKey(o => o.Id);

  
            builder.HasOne(o => o.Usuarios).
                WithMany(o => o.Compartirs).
                HasForeignKey(o => o.IdUsuario);

   

            builder.HasOne(o => o.Notas).
                WithMany(o => o.Compartirs).
                HasForeignKey(o => o.IdNota);
        }
    }
}
