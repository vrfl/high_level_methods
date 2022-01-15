using System;

namespace Lab4

{
    public class ColoredPoint : Point
    {
        private Colors _color;

        public ColoredPoint() : base()
        {
            _color = Colors.Black;
        }
        public ColoredPoint(double x, double y, Colors color) : base(x, y)
        {
            _color = color;
        }
        public Colors Color { get => _color; set => _color = value; }
        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (ColoredPoint)obj;

            return base.Equals(other) && _color == other._color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_color);
        }

        public override string ToString()
        {
            return base.ToString() + $"color: {_color}";
        }
    }
}