using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Divizie
    {
        public Divizie()
        {
            Projekty = new HashSet<Projekty>();
        }

        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int? IdVeduciDiv { get; set; }
        public int? IdPatriPod { get; set; }

        public virtual Firma? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciDivNavigation { get; set; }
        public virtual ICollection<Projekty> Projekty { get; set; }
    }
}
