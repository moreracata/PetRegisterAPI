using System;
using System.Collections.Generic;

namespace PetRegisterAPI.ModelsDTO
{
    public partial class PetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal? Weight { get; set; }
        public int? Age { get; set; }
        public string? City { get; set; }
        public string? Color { get; set; }
        public int CategoriesId { get; set; }
        public int OwnerId { get; set; }
        public DateTime? Birthdate { get; set; }
        public string? PhotoUrl { get; set; }


    }
}
