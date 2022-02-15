using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models
{
    public partial class Zamestnanci
    {
        public Zamestnanci()
        {
            Divizies = new HashSet<Divizie>();
            Firmas = new HashSet<Firma>();
            Oddelenia = new HashSet<Oddelenium>();
            Projekties = new HashSet<Projekty>();
        }

        public int Id { get; set; }
        public string? Titul { get; set; }
        public string Meno { get; set; } = null!;
        public string Priezvisko { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Divizie> Divizies { get; set; }
        public virtual ICollection<Firma> Firmas { get; set; }
        public virtual ICollection<Oddelenium> Oddelenia { get; set; }
        public virtual ICollection<Projekty> Projekties { get; set; }
    }
}
