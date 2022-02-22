using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public partial class Oddelenia : BaseNode {
        public int Id { get; set; }
        public virtual Projekty? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciNavigation { get; set; }
    }
}
