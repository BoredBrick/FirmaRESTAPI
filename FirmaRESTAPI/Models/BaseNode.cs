namespace FirmaRESTAPI.Models {
    public class BaseNode {
        public string Nazov { get; set; } = null!;
        public int? IdVeduci { get; set; }
        public int? IdPatriPod { get; set; }

        public BaseNode(string nazov, int? idVeduci, int? idPatriPod) {
            this.Nazov = nazov;
            this.IdVeduci = idVeduci;
            this.IdPatriPod = idPatriPod;
        }

        public BaseNode() {
        }

        public Oddelenia baseToOddelenia() {
            return new Oddelenia() {
                Nazov = Nazov,
                IdVeduci = IdVeduci,
                IdPatriPod = IdPatriPod
            };
        }
        public Projekty baseToProjekty() {
            return new Projekty() {
                Nazov = Nazov,
                IdVeduci = IdVeduci,
                IdPatriPod = IdPatriPod
            };
        }
        public Divizie baseToDivizie() {
            return new Divizie() {
                Nazov = Nazov,
                IdVeduci = IdVeduci,
                IdPatriPod = IdPatriPod
            };
        }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }
    }
}
