using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Projekty
    {
        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int IdVeduciProj { get; set; }

        public virtual Zamestnanci IdVeduciProjNavigation { get; set; } = null!;
    }
}
