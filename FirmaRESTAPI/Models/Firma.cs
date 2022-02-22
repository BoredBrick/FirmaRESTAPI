using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public partial class Firma : FirmaNode {
        public Firma() {
            Divizie = new HashSet<Divizie>();
        }

        public Firma(FirmaNode node) : base(node) { }

        public int Id { get; set; }

        public virtual Zamestnanci? IdVeduciNavigation { get; set; }
        public virtual ICollection<Divizie> Divizie { get; set; }
    }
}
