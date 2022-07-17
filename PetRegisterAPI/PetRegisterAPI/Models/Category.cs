using System;
using System.Collections.Generic;

namespace PetRegisterAPI.Models
{
    public partial class Category
    {
        public Category()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
