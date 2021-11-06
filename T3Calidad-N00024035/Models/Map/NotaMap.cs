using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T3Calidad_N00024035.Models.Map
{
    public class NotaMap : IEntityTypeConfiguration<Nota>

    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.ToTable("Nota");
            builder.HasKey(o => o.Id);


        }
    }
}
