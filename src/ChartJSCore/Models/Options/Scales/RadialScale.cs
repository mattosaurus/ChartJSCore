namespace ChartJSCore.Models
{
    public class RadialScale : Scale
    {
        public AngleLine AngleLines { get; set; }

        public Grid Grid { get; set; }

        public PointLabel PointLabels { get; set; }

        public Tick Ticks { get; set; }
    }
}
