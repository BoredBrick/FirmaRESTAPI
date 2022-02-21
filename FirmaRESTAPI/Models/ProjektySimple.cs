using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class ProjektySimple {


        public string Nazov { get; set; } = null!;
        public int? IdVeduciProj { get; set; }
        public int? IdPatriPod { get; set; }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }

        public Projekty simpleToProject() {
            return new Projekty {
                Nazov = Nazov,
                IdVeduciProj = IdVeduciProj,
                IdPatriPod = IdPatriPod
            };
        }

    }
}
