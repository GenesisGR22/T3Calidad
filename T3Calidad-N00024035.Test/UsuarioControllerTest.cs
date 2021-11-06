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
    public class UsuarioControllerTest
    {
        [Test]
        public void InSessionGet()
        {

            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<IUsuarioRepository>();

            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Login() as ViewResult;

            Assert.AreEqual("Login", view.ViewName);
        }
        [Test]
        public void InSessionPost()
        {
            var claim = new Mock<IClaimService>();
            var repository = new Mock<IUsuarioRepository>();
            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Login("genesis", "genesis") as ViewResult;
            Assert.AreEqual("Login", view.ViewName);

        }
        [Test]
        public void CreateGet()
        {
            var claim = new Mock<IClaimService>();
            var repository = new Mock<IUsuarioRepository>();
            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Create() as ViewResult;
            Assert.AreEqual("Create", view.ViewName);
        }

        [Test]
        public void CrearPost()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(s => s.LoggedUser()).Returns(new Usuario());
            var repository = new Mock<IUsuarioRepository>();
            var controller = new UsuarioController(repository.Object, claim.Object);
            var view = controller.Create(new Usuario { }, "gspr", "gspr") as RedirectToActionResult;
            Assert.AreEqual("Login", view.ActionName);
        }

    }
}
