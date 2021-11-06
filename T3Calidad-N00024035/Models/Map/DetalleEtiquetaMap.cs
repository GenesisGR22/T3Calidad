using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3Calidad_N00024035.Models.Map
{
    public class EtiquetaNotaMap : IEntityTypeConfiguration<DetalleEtiquetaNota>

    {
        public void Configure(EntityTypeBuilder<DetalleEtiquetaNota> builder)
        {
            builder.ToTable("DetalleEtiquetaNota");
            builder.HasKey(o => o.Id);


            builder.HasOne(o => o.Etiquetas).
            WithMany().
            HasForeignKey(o => o.IdEtiqueta);

            builder.HasOne(o => o.Notas).
           WithMany().
           HasForeignKey(o => o.IdNota);

        }
    }
}
