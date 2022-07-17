using System;
using System.Collections.Generic;

namespace PetRegisterAPI.Models
{
    public partial class Provincia
    {
        public Provincia()
        {
            Cantons = new HashSet<Canton>();
            Distritos = new HashSet<Distrito>();
            Owners = new HashSet<Owner>();
        }

        public int Id { get; set; }
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }

        public virtual ICollection<Canton> Cantons { get; set; }
        public virtual ICollection<Distrito> Distritos { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
