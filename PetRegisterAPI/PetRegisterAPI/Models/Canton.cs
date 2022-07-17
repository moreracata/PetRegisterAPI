using System;
using System.Collections.Generic;

namespace PetRegisterAPI.Models
{
    public partial class Canton
    {
        public Canton()
        {
            Distritos = new HashSet<Distrito>();
            Owners = new HashSet<Owner>();
        }

        public int Id { get; set; }
        public int CantonId { get; set; }
        public int ProvinciaId { get; set; }
        public string Nombre { get; set; } = null!;
        public string? CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }

        public virtual Provincia Provincia { get; set; } = null!;
        public virtual ICollection<Distrito> Distritos { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}
