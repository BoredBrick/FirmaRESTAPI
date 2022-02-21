using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class DivizieSimple {

        public string Nazov { get; set; } = null!;
        public int? IdVeduciDiv { get; set; }
        public int? IdPatriPod { get; set; }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }

        public Divizie simpleToDivizie() {
            return new Divizie {
                Nazov = Nazov,
                IdVeduciDiv = IdVeduciDiv,
                IdPatriPod = IdPatriPod
            };
        }
    }
}
