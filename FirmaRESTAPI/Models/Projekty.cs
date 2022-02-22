using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public partial class Projekty : BaseNode {
        public Projekty() {
            Oddelenia = new HashSet<Oddelenia>();
        }
        public int Id { get; set; }

        public Projekty(BaseNode node) : base(node) { }

        public virtual Divizie? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciNavigation { get; set; }
        public virtual ICollection<Oddelenia> Oddelenia { get; set; }

    }
}
