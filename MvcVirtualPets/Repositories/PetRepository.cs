using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MvcVirtualPets.Models;

namespace MvcVirtualPets.Repositories
{
    public class PetRepository
    {
        PetContext db;
        public PetRepository(PetContext db)
        {
            this.db = db; 
        }

        public IEnumerable<Pet> GetAll()
        {
            return db.Pets.ToList();
        }

        public Pet GetById(int id)
        {
            return db.Pets.Single(pet => pet.Id == id);
        }

        public void Create(Pet pet)
        {
            //db.Set<Pet>().Add(pet);
            db.Pets.Add(pet);
            db.SaveChanges();
        }

        public void Delete(Pet pet)
        {
            //db.Set<Pet>().Remove(pet);
            db.Pets.Remove(pet);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Pet pet)
        {
            //db.Attach(pet);
            //db.Entry(entity).State = EntityState.Modified;
            db.Update(pet);
            db.SaveChanges();
        }


    }
}
