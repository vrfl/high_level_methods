using System;
namespace Lab4
{
    class ColoredLine : Line
    {
        private Colors _color;

        public ColoredLine() : base()
        {
            _color = Colors.Black;
        }
        public ColoredLine(Point StartPoint, Point EndPoint, Colors color) : base(StartPoint, EndPoint)
        {
            _color = color;
        }
        public Colors Color { get => _color; set => _color = value; }
        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (ColoredLine)obj;

            return _color == other._color;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_color);
        }

        public override string ToString()
        {
            return base.ToString() + $" color: {_color}";
        }
    }
}