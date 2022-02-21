using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class ZamestnanciSimple {
        public string? Titul { get; set; }
        public string Meno { get; set; } = null!;
        public string Priezvisko { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;



        public bool isValid() {
            if (string.IsNullOrWhiteSpace(Meno) || string.IsNullOrWhiteSpace(Priezvisko)
                || string.IsNullOrWhiteSpace(Telefon) || string.IsNullOrWhiteSpace(Email)) {
                return false;
            }
            return true;
        }

        public Zamestnanci SimpleToZamestnanec() {
            return new Zamestnanci {
                Titul = this.Titul,
                Meno = this.Meno,
                Priezvisko = this.Priezvisko,
                Telefon = this.Telefon,
                Email = this.Email
            };
        }
    }
}
