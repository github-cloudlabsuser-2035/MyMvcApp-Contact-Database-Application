using Xunit;
using MyMvcApp.Controllers;
using MyMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyMvcApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Index_ReturnsAViewResult_WithAListOfUsers()
        {
            // Arrange
            var controller = new UserController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<User>>(viewResult.ViewData.Model);
            Assert.NotNull(model);
        }

        // Agrega más pruebas para las otras acciones
    }
}