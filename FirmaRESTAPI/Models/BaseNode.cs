namespace FirmaRESTAPI.Models {
    public class BaseNode {
        public string Nazov { get; set; } = null!;
        public int? IdVeduci { get; set; }
        public int? IdPatriPod { get; set; }

        public BaseNode(BaseNode node) {
            Nazov = node.Nazov;
            IdVeduci = node.IdVeduci;
            IdPatriPod = node.IdPatriPod;
        }

        public BaseNode() {
        }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }
    }
}
