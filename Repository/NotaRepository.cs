using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3Calidad_N00024035.Models;

namespace T3Calidad_N00024035.Repository
{
    public interface INotaRepository
    {
        List<Usuario> GetUsuarios();
        List<Etiqueta> GetEtiqueta();
        List<DetalleEtiquetaNota> GetDetalleEtiquetaNota();
        List<DetalleEtiquetaNota> GetDetalleEtiquetaNota2();
        List<DetalleEtiquetaNota> GetDetalleEtiquetaNota3(int idEtiqueta);
        List<Nota> GetNota();
        Nota GetNota2(int id);
        void saveNota(Nota nota);
        void UpdateNota(Nota nota);
        void saveDetEtiqNota(List<DetalleEtiquetaNota> etic);
        void DeleteNota(Nota nota, List<DetalleEtiquetaNota> etic);
    }
    public class NotaRepository: INotaRepository
    {
        private readonly IN00024035Context _context;

        public NotaRepository(N00024035Context _context)
        {
            this._context = _context;
        }

        public void DeleteNota(Nota nota, List<DetalleEtiquetaNota> etic)
        {
            _context.Notas.Remove(nota);
            _context.DetalleEtiquetaNotas.RemoveRange(etic);
            _context.SaveChanges();
        }

        

      

        public List<DetalleEtiquetaNota> GetDetalleEtiquetaNota()
        {
            return _context.DetalleEtiquetaNotas.ToList();
        }

        public List<DetalleEtiquetaNota> GetDetalleEtiquetaNota2()
        {
            return _context.DetalleEtiquetaNotas.Include(o => o.Etiquetas).ToList();
        }

        public List<DetalleEtiquetaNota> GetDetalleEtiquetaNota3(int idEtiqueta)
        {
            return _context.DetalleEtiquetaNotas.Where(x => x.IdEtiqueta == idEtiqueta).
                Include(z => z.Notas).ToList();
        }

        public List<Etiqueta> GetEtiqueta()
        {
            return _context.Etiquetas.ToList();
        }

        public List<Nota> GetNota()
        {
            return _context.Notas.ToList();
        }

        public Nota GetNota2(int id)
        {
            return _context.Notas.Where(o => o.Id == id).FirstOrDefault();
        }

        public List<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

   

        public void saveDetEtiqNota(List<DetalleEtiquetaNota> etic)
        {
            _context.DetalleEtiquetaNotas.AddRange(etic);
            _context.SaveChanges();
        }

        public void saveNota(Nota nota)
        {
            _context.Notas.Add(nota);
            _context.SaveChanges();
        }

        public void UpdateNota(Nota nota)
        {
            _context.Notas.Update(nota);
            _context.SaveChanges();
        }
    }
}
