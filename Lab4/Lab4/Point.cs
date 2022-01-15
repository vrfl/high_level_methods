using System;
namespace Lab4
{
    public class Point
    {
        private double _x;
        private double _y;

        public Point()
        {
            _x = 0.0;
            _y = 0.0;
        }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (Point)obj;

            return _x == other._x && _y == other._y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }

        public override string ToString()
        {
            return @$"({_x}; {_y})";
        }

    }
}