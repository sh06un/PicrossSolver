using System.Drawing;

namespace Domain.Picross {
    public class ColorClassifier {
        public Color MyColor { get; set; }
        public int Count { get; set; }
        public bool IsConnected { get; set; }
        public bool IsDone { get; set; }
    }
}