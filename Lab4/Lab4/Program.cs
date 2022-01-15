using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine((new Point()).ToString());
            Console.WriteLine((new Point(10.0, 14.0)).ToString());

            Console.WriteLine((new ColoredPoint()).ToString());
            Console.WriteLine((new ColoredPoint(10.0, 14.0, color: Colors.Orange)).ToString());

            Console.WriteLine((new Line()).ToString());
            Line line = new Line(new Point(), new Point(10.0, 0));
            Console.WriteLine(line.ToString());
            line.turnWithAngle(90);
            Console.WriteLine(line.ToString());
            line.turnWithAngle(180);
            Console.WriteLine(line.ToString());
            line.turnWithAngle(120);
            Console.WriteLine(line.ToString());


            Console.WriteLine((new ColoredLine()).ToString());
            Line coloredLine = new ColoredLine(new Point(), new Point(10.0, 0), Colors.Blue);
            Console.WriteLine(coloredLine.ToString());
            coloredLine.turnWithAngle(90);
            Console.WriteLine(coloredLine.ToString());
            coloredLine.turnWithAngle(180);
            Console.WriteLine(coloredLine.ToString());

            Console.WriteLine((new Polygone()).ToString());
            Polygone polygone = new Polygone();
            Console.WriteLine(polygone.ToString());
            polygone.Scale(2.0);
            Console.WriteLine(polygone.ToString());
        }
    }
}
