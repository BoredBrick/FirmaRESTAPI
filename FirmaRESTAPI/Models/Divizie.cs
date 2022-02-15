using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Divizie
    {
        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int IdVeduciDiv { get; set; }

        public virtual Zamestnanci IdVeduciDivNavigation { get; set; } = null!;
    }
}
