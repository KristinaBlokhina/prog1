using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr.lab1
{
    public class Polygon
    {
        private List<(double x, double y)> vertices;

        public Polygon(List<(double x, double y)> vertices)
        {
            if (vertices.Count < 3)
                throw new ArgumentException("Polygon must have at least 3 vertex.");

            this.vertices = vertices;
        }

        public double this[int index]
        {
            get
            {
                int nextIndex = (index + 1) % vertices.Count;
                return GetDistance(vertices[index], vertices[nextIndex]);
            }
        }

        public double GetPerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < vertices.Count; i++)
            {
                perimeter += this[i];
            }
            return perimeter;
        }

        public double GetArea()
        {
            double area = 0;
            int n = vertices.Count;

            for (int i = 0; i < n; i++)
            {
                (double x1, double y1) = vertices[i];
                (double x2, double y2) = vertices[(i + 1) % n];
                area += x1 * y2 - x2 * y1;
            }

            return Math.Abs(area) / 2.0;
        }

        public void PrintPolygon()
        {
            Console.WriteLine("Polygon`s vertex:");
            for (int i = 0; i < vertices.Count; i++)
            {
                Console.WriteLine($"Vertex {i + 1}: ({vertices[i].x}, {vertices[i].y})");
            }
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Spaсe: {GetArea()}");
        }

        private double GetDistance((double x, double y) point1, (double x, double y) point2)
        {
            return Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));
        }
    }
}
