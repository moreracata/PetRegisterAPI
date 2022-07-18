using System;
using System.Collections.Generic;

namespace PetRegisterAPI.ModelsDTO
{
    public partial class OwnerDTO
    {
     
        public int Id { get; set; }
        public int Nss { get; set; }
        public string LastName { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? Address { get; set; }
        public string? AddressLongitude { get; set; }
        public string? AddressLatitude { get; set; }
        public int? ProvinciaId { get; set; }
        public int? CantonId { get; set; }
        public int? DistritoId { get; set; }
        public string Phone { get; set; } = null!;
        public string Cellphone { get; set; } = null!;
        public DateTime? Birthdate { get; set; }
        public string? PhotoUrl { get; set; }
    }
}
