using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Oddelenium
    {
        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int IdVeduciOdd { get; set; }

        public virtual Zamestnanci IdVeduciOddNavigation { get; set; } = null!;
    }
}
