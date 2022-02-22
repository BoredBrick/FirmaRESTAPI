using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public partial class Oddelenia : BaseNode {
        public int Id { get; set; }

        public Oddelenia(BaseNode node) : base(node) { }

        public Oddelenia() {
        }

        public virtual Projekty? IdPatriPodNavigation { get; set; }
        public virtual Zamestnanci? IdVeduciNavigation { get; set; }
    }
}
