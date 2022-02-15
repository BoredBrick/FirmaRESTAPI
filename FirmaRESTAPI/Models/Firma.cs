using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Firma
    {
        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int IdRiaditel { get; set; }

        public virtual Zamestnanci IdRiaditelNavigation { get; set; } = null!;
    }
}
