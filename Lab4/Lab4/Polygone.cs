using System;

using System.Linq;

namespace Lab4
{
    public class Polygone
    {
        private Point[] _vertexes;

        public Polygone()
        {
            _vertexes = new Point[] { new Point(0, 5), new Point(10, 0), new Point(5, -5), new Point(-5, -5), new Point(-10, 0), };
        }
        public Polygone(Point[] vertexes)
        {
            _vertexes = vertexes;
        }

        Point[] Vertexes { get => _vertexes; set => _vertexes = value; }

        public void Scale(double scaleValue)
        {
            double centerX = (_vertexes.Select(el => el.X).Sum()) / _vertexes.Length;
            double centerY = _vertexes.Select(el => el.Y).Sum() / _vertexes.Length;

            Point[] vectors = _vertexes.Select(el => new Point(el.X - centerX, el.Y - centerY)).ToArray();
            Point[] scaledVectors = vectors.Select(el => new Point(el.X * scaleValue, el.Y * scaleValue)).ToArray();
            _vertexes = scaledVectors;
        }

        public override bool Equals(object obj)
        {
            if (obj?.GetType() != GetType())
                return false;

            var other = (Polygone)obj;

            return _vertexes.Length == other._vertexes.Length && _vertexes.SequenceEqual(other._vertexes);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_vertexes);
        }

        public override string ToString()
        {
            return string.Join(", ", _vertexes.Select(el => el.ToString()).ToArray());
        }
    }

}