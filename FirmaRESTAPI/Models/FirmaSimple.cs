using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class FirmaSimple {

        public string Nazov { get; set; } = null!;
        public int? IdRiaditel { get; set; }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }


        public Firma SimpleToFirma() {
            return new Firma {

                Nazov = Nazov,
                IdRiaditel = IdRiaditel,
            };
        }
    }
}
