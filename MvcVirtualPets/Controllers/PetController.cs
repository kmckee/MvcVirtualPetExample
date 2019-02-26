using Microsoft.AspNetCore.Mvc;
using MvcVirtualPets.Models;
using MvcVirtualPets.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Controllers
{
    public class PetController : Controller
    {
        PetRepository petRepo;
        public PetController()
        {
            petRepo = new PetRepository();
        }

        public ViewResult Index()
        {
            var model = petRepo.GetAll(); 
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = petRepo.GetById(id); 
            return View(model);
        }
    }
}
