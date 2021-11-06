using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3Calidad_N00024035.Models;
using T3Calidad_N00024035.Repository;
using T3Calidad_N00024035.Services;

namespace T3Calidad_N00024035.Controllers
{
    //[Authorize]
    public class NotaController : Controller
    {
        List<DetalleEtiquetaNota> etic = new List<DetalleEtiquetaNota>();

        private readonly INotaRepository context;
        private readonly IClaimService claim;
        public NotaController(INotaRepository context, IClaimService claim)
        {
            this.context = context;
            this.claim = claim;
            claim.SetHttpContext(HttpContext);
        }
        [HttpGet]
        public IActionResult Index()
        {
            claim.SetHttpContext(HttpContext);
            ViewBag.Etiquetas = context.GetEtiqueta();
            ViewBag.Etiquetitas = context.GetDetalleEtiquetaNota();
            ViewBag.NameUser = claim.LoggedUser().Nombre;
            return View("Index");
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {
            claim.SetHttpContext(HttpContext);
            var notas = context.GetNota().Where(x => x.IdUsuario == claim.LoggedUser().Id).ToList();

            /*var Buscador = context.DetalleEtiquetaNotas.Include(a=>a.Etiquetas).
                Include(s=>s.Notas).
                ToList();*/

            ViewBag.Etiquetas = context.GetEtiqueta();
            ViewBag.Etiquetitas = context.GetDetalleEtiquetaNota();

            if (!String.IsNullOrEmpty(search))
            {
                notas = notas.Where(o => o.Titulo.Contains(search) || o.Contenido.Contains(search)).ToList();
                //Buscador = Buscador.Where(o => o.Notas.Titulo.Contains(search) || o.Notas.Contenido.Contains(search) || o.Etiquetas.Nombre.Contains(search)).ToList();

                return View("_Index", notas);
            }
            return View(notas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            claim.SetHttpContext(HttpContext);
            ViewBag.Etiquetas = context.GetEtiqueta();
            return View("Create", new Nota());
        }
        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            claim.SetHttpContext(HttpContext);
            List<DetalleEtiquetaNota> etic = new List<DetalleEtiquetaNota>();

            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta", "Seleccione por lo menos uno");
            if (nota.Titulo == null)
                ModelState.AddModelError("titulo", "Campo requerido");
            if (nota.Contenido == null)
                ModelState.AddModelError("contenido", "Campo requerido");

            nota.Fecha = DateTime.Now;
            nota.IdUsuario = claim.LoggedUser().Id;
            if (ModelState.IsValid)
            {
                context.saveNota(nota);
                foreach (var item in etiqueta)
                {
                    var etique = new DetalleEtiquetaNota();
                    etique.IdEtiqueta = item;
                    etique.IdNota = nota.Id;
                    etic.Add(etique);
                }
                context.saveDetEtiqNota(etic);


                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.GetEtiqueta();
                return View(nota);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            claim.SetHttpContext(HttpContext);
            ViewBag.Etiquetas = context.GetEtiqueta();
            var nota = context.GetNota2(id);
            return View("Edit", nota);
        }
        [HttpPost]
        public IActionResult Edit(Nota nota)
        {
            claim.SetHttpContext(HttpContext);
            nota.IdUsuario = claim.LoggedUser().Id;
            nota.Fecha = DateTime.Now;
            if (ModelState.IsValid)
            {
                context.UpdateNota(nota);
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.GetEtiqueta();
                return View(nota);
            }
        }

        [HttpGet]
        public IActionResult Detalle(int id)
        {
            claim.SetHttpContext(HttpContext);
            var etiqueta = context.GetEtiqueta();
            ViewBag.Etiquetas = context.GetDetalleEtiquetaNota2();
            ViewBag.nota = context.GetNota2(id);
            ViewBag.idNota = id;
            ViewBag.idUsuario = claim.LoggedUser().Id;
            ViewBag.usuarios = context.GetUsuarios().Where(f => f.Id != claim.LoggedUser().Id).ToList();
            return View("Detalle");
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            claim.SetHttpContext(HttpContext);
            var nota = context.GetNota2(id);
            var etiqueta = context.GetDetalleEtiquetaNota().Where(o => o.IdNota == id).ToList();
            context.DeleteNota(nota, etiqueta);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Lista(int idEtiqueta, string titulo)
        {
            claim.SetHttpContext(HttpContext);
            ViewBag.DetalleEtiquetaNota = context.GetDetalleEtiquetaNota3(idEtiqueta);
            ViewBag.Titulo = titulo;

            return View("Lista");
        }
        
       
    }
}
