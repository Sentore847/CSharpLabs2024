using System;

namespace GeometryApp
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }
    }

    class Figure
    {
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
            }

            Console.WriteLine("The perimeter of the figure is: " + perimeter);
        }

        public void ShowFigure()
        {
            Console.Write("The figure is formed by points: ");
            foreach (var point in points)
            {
                Console.Write(point.Name + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 3, "B");
            Point C = new Point(4, 0, "C");
            Point D = new Point(4, 3, "D");
            Point E = new Point(2, 5, "E");

            Figure triangle = new Figure(A, B, C);
            triangle.ShowFigure();
            triangle.PerimeterCalculator();

            Figure quadrilateral = new Figure(A, B, C, D);
            quadrilateral.ShowFigure();
            quadrilateral.PerimeterCalculator();

            Figure pentagon = new Figure(A, B, C, D, E);
            pentagon.ShowFigure();
            pentagon.PerimeterCalculator();
        }
    }
}
