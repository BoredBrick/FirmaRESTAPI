using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class ZamestnanciNode {
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

        public ZamestnanciNode(ZamestnanciNode node) {
            Titul = node.Titul;
            Meno = node.Meno;
            Priezvisko = node.Priezvisko;
            Telefon = node.Telefon;
            Email = node.Email;
        }

        public ZamestnanciNode() {
        }
    }
}
