using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class FirmaNode {

        public string Nazov { get; set; } = null!;
        public int? IdVeduci { get; set; }

        public FirmaNode(string nazov, int? idVeduci) {
            this.Nazov = nazov;
            this.IdVeduci = idVeduci;
        }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }

        public Firma NodeToFirma() {
            return new Firma {
                Nazov = Nazov,
                IdVeduci = IdVeduci,
            };
        }
    }
}
