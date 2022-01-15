using System;

namespace Lab4
{
    public class Line
    {
        private Point _startPoint;
        private Point _endPoint;

        public Line()
        {
            _startPoint = new Point(0.0, 0.0);
            _endPoint = new Point(10.0, 0.0);
        }

        public Line(Point startPoint, Point endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        private Point StartPoint { get => _startPoint; set => _startPoint = value; }
        private Point EndPoint { get => _endPoint; set => _endPoint = value; }

        public void turnWithAngle(double angle)
        {
            double distance = Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2));
            double cos = Math.Round(Math.Cos(angle * 0.0174533));
            double sin = Math.Round(Math.Sin(angle * 0.0174533));
            _endPoint = new Point(_endPoint.X * cos - _endPoint.Y * sin, _endPoint.X * sin + _endPoint.Y * cos);
        }

        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (Line)obj;

            return _startPoint.Equals(other._endPoint);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_startPoint, EndPoint);
        }

        public override string ToString()
        {
            return @$"({_startPoint.ToString()}; {_endPoint.ToString()})";
        }

    }
}