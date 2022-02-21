using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public partial class Zamestnanci {
        public Zamestnanci() {
            Divizie = new HashSet<Divizie>();
            Firma = new HashSet<Firma>();
            Oddelenia = new HashSet<Oddelenia>();
            Projekty = new HashSet<Projekty>();
        }


        public ZamestnanciSimple ZamestnanciToSimple() {
            return new ZamestnanciSimple {
                Titul = this.Titul,
                Meno = this.Meno,
                Priezvisko = this.Priezvisko,
                Telefon = this.Telefon,
                Email = this.Email
            };
        }


        public int Id { get; set; }
        public string? Titul { get; set; }
        public string Meno { get; set; } = null!;
        public string Priezvisko { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Divizie> Divizie { get; set; }
        public virtual ICollection<Firma> Firma { get; set; }
        public virtual ICollection<Oddelenia> Oddelenia { get; set; }
        public virtual ICollection<Projekty> Projekty { get; set; }
    }
}
