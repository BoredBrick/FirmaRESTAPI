using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class OddeleniaSimple {
        public string Nazov { get; set; } = null!;
        public int? IdVeduciOdd { get; set; }
        public int? IdPatriPod { get; set; }


        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }

        public Oddelenia simpleToOddelenia() {
            return new Oddelenia {
                Nazov = Nazov,
                IdVeduciOdd = IdVeduciOdd,
                IdPatriPod = IdPatriPod
            };
        }
    }
}
