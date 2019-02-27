using Microsoft.AspNetCore.Mvc;
using MvcVirtualPets.Controllers;
using MvcVirtualPets.Models;
using MvcVirtualPets.Repositories;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MvcVirtualPets.Tests
{
    public class PetControllerTests
    {
        PetController underTest;
        public PetControllerTests()
        {
            var context = new PetContext();
            var repo = new PetRepository(context);
            underTest = new PetController(repo);
        }

        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Model_Has_3_Pets()
        {
            var result = underTest.Index();
            var model = (IEnumerable<Pet>)result.Model;
            Assert.Equal(3, model.Count());
        }

        [Fact]
        public void Details_Model_Has_Correct_Id()
        {
            var expectedId = 2;
            var result = underTest.Details(expectedId);
            var model = (Pet)result.Model;
            Assert.Equal(expectedId, model.Id);
        }
    }
}
