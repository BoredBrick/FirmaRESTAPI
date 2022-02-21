using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Projekty
    {
        public Projekty()
        {
            Oddelenia = new HashSet<Oddelenia>();
        }

        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int? IdVeduciProj { get; set; }
        public int? IdPatriPod { get; set; }

        public virtual Divizie? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciProjNavigation { get; set; }
        public virtual ICollection<Oddelenia> Oddelenia { get; set; }
    }
}
