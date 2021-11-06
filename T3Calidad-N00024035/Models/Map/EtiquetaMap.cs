﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3Calidad_N00024035.Models.Map
{
    public class EtiquetaMap : IEntityTypeConfiguration<Etiqueta>

    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.ToTable("Etiqueta");
            builder.HasKey(o => o.Id);
        }
    }
}
