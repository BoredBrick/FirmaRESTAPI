using System;
using System.Collections.Generic;

namespace FirmaRESTAPI.Models {
    public class FirmaNode {

        public string Nazov { get; set; } = null!;
        public int? IdVeduci { get; set; }

        public FirmaNode(FirmaNode node) {
            Nazov = node.Nazov;
            IdVeduci = node.IdVeduci;
        }

        public FirmaNode() {
        }

        public bool isValid() {
            return !string.IsNullOrWhiteSpace(Nazov);
        }

    }
}
