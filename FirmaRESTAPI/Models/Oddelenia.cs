﻿using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Oddelenia
    {
        public int Id { get; set; }
        public string Nazov { get; set; } = null!;
        public int? IdVeduciOdd { get; set; }
        public int? IdPatriPod { get; set; }

        public virtual Projekty? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciOddNavigation { get; set; }
    }
}
