using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Firma
    {
        public Firma()
        {
            Divizie = new HashSet<Divizie>();
        }

        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int? IdVeduci { get; set; }

        public virtual Zamestnanci? IdVeduciNavigation { get; set; }
        public virtual ICollection<Divizie> Divizie { get; set; }
    }
}
