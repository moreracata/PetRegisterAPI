using System;
using System.Collections.Generic;

namespace PetRegisterAPI.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Owners = new HashSet<Owner>();
        }

        public int Id { get; set; }
        public int DistritoId { get; set; }
        public int CantonId { get; set; }
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }

        public virtual Canton Canton { get; set; } = null!;
        public virtual Provincia Provincia { get; set; } = null!;
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
