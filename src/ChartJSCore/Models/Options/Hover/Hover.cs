namespace ChartJSCore.Models
{
    public class Hover : Base
    {
        public string Mode { get; set; }

        public bool? Intersect { get; set; }

        public int? AnimationDuration { get; set; }

        public string OnHover { get; set; }
    }
}
