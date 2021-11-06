using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3Calidad_N00024035.Models.Map;

namespace T3Calidad_N00024035.Models
{
   
    public interface IN00024035Context
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Nota> Notas { get; set; }
        DbSet<Etiqueta> Etiquetas { get; set; }
        DbSet<DetalleEtiquetaNota> DetalleEtiquetaNotas { get; set; }
  
        int SaveChanges();
    }
    public class N00024035Context : DbContext, IN00024035Context
    {
        public N00024035Context(DbContextOptions<N00024035Context> options)
           : base(options) { }
        public N00024035Context() { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<DetalleEtiquetaNota> DetalleEtiquetaNotas { get; set; }
     


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaNotaMap());
        

        }
    }
}
