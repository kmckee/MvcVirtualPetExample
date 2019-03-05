using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVirtualPets.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Pet name is required.")]
        [Display(Name = "Pet Name.")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
