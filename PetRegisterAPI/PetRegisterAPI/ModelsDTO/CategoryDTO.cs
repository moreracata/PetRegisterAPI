
using System;
using System.Collections.Generic;

namespace PetRegisterAPI.Models
{
    public partial class CategoryDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
