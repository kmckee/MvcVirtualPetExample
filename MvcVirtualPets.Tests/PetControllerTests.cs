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
            // The code below is bad!  Our tests rely on multiple classes, a database,
            // and even specific data inside the database.  Tests like this are known as
            // integration tests.  We will eventually refactor this test to remove all
            // external dependencies so that our test is a Unit Test (not integration) and
            // tests only the PetController class in isolation.
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
