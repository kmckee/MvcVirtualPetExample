using System.Collections.Generic;
using System.Linq;
using MvcVirtualPets.Models;

namespace MvcVirtualPets.Repositories
{
    public class PetRepository
    {
        Dictionary<int, Pet> pets = new Dictionary<int, Pet>()
        {
            { 1, new Pet() { Id = 1, Name = "Roscoe" } },
            { 2, new Pet() { Id = 2, Name = "Biggs" } },
            { 3, new Pet() { Id = 3, Name = "Bella" } }
        };

        public IEnumerable<Pet> GetAll()
        {
            return pets.Values.ToList();
        }

        public Pet GetById(int id)
        {
            return pets[id];
        }
    }
}
