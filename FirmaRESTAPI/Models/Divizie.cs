using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public partial class Divizie : BaseNode {
        public Divizie() {
            Projekty = new HashSet<Projekty>();
        }

        public Divizie(BaseNode node) : base(node) { }
        public int Id { get; set; }

        public virtual Firma? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciNavigation { get; set; }
        public virtual ICollection<Projekty> Projekty { get; set; }
    }
}
