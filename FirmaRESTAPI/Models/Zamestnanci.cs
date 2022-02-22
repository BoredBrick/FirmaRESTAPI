
namespace FirmaRESTAPI.Models {
    public partial class Zamestnanci : ZamestnanciNode {
        public Zamestnanci() {
            Divizie = new HashSet<Divizie>();
            Firma = new HashSet<Firma>();
            Oddelenia = new HashSet<Oddelenia>();
            Projekty = new HashSet<Projekty>();
        }

        public int Id { get; set; }

        public virtual ICollection<Divizie> Divizie { get; set; }
        public virtual ICollection<Firma> Firma { get; set; }
        public virtual ICollection<Oddelenia> Oddelenia { get; set; }
        public virtual ICollection<Projekty> Projekty { get; set; }
    }
}
