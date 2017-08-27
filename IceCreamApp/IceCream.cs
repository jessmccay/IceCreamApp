namespace IceCreamApp
{
    public class IceCream
    {
        private string _color;
        public string Color
        {
            get { return Color; }
            set { Color = _color; }
        }
        public IceCream(string color)
        {
            _color = color;
        }
    }
}