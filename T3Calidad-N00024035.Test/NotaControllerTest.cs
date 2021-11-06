using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using T3Calidad_N00024035.Controllers;
using T3Calidad_N00024035.Models;
using T3Calidad_N00024035.Repository;
using T3Calidad_N00024035.Services;

namespace T3Calidad_N00024035.Test
{
    [TestFixture]
    public class NotaControllerTest
    {
        [Test]
        public void IndexGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();

            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Index() as ViewResult;

            Assert.AreEqual("Index", view.ViewName);


        }
        [Test]
        public void IndexGetSearch()
        {


            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();
            repository.Setup(s => s.GetNota()).Returns(new List<Nota>());
            repository.Setup(s => s.GetEtiqueta()).Returns(new List<Etiqueta>());
            repository.Setup(s => s.GetDetalleEtiquetaNota()).Returns(new List<DetalleEtiquetaNota>());
            var controller = new NotaController(repository.Object, claim.Object);
            string search = "llico";
            var view = controller._Index(search) as ViewResult;

            Assert.AreEqual("_Index", view.ViewName);
        }
        [Test]
        public void CreateGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();

            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Create() as ViewResult;

            Assert.AreEqual("Create", view.ViewName);


        }
        [Test]
        public void EditGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();
            repository.Setup(s => s.GetEtiqueta()).Returns(new List<Etiqueta>());
            repository.Setup(s => s.GetNota2(1)).Returns(new Nota());
            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Edit(1) as ViewResult;

            Assert.AreEqual("Edit", view.ViewName);
        }
        [Test]
        public void EditPost()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();
            repository.Setup(s => s.GetEtiqueta()).Returns(new List<Etiqueta>());
            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Edit(new Nota() { }) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }
        [Test]
        public void DetalleGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();
            repository.Setup(s => s.GetDetalleEtiquetaNota2()).Returns(new List<DetalleEtiquetaNota>());
            repository.Setup(s => s.GetNota2(1)).Returns(new Nota());
            repository.Setup(s => s.GetUsuarios()).Returns(new List<Usuario>());
            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Detalle(1) as ViewResult;

            Assert.AreEqual("Detalle", view.ViewName);
        }
        [Test]
        public void EliminarGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();
            repository.Setup(s => s.GetNota2(1)).Returns(new Nota());
            repository.Setup(s => s.GetDetalleEtiquetaNota()).Returns(new List<DetalleEtiquetaNota>());

            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Eliminar(1) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }
        [Test]
        public void ListaGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<INotaRepository>();
            repository.Setup(s => s.GetDetalleEtiquetaNota3(1)).Returns(new List<DetalleEtiquetaNota>());

            var controller = new NotaController(repository.Object, claim.Object);
            var view = controller.Lista(1, "Yamaha") as ViewResult;

            Assert.AreEqual("Lista", view.ViewName);
        }
         
       
    }
}
