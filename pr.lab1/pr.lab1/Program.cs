using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr.lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vertices = new List<(double x, double y)>
            {
                (0,0),
                (4,0),
                (4,3),
                (0,3)
            };
            var polygon = new Polygon(vertices);
            polygon.PrintPolygon();

            for(int i=0;i<vertices.Count;i++)
            {
                Console.WriteLine($"length of side {i + 1}:{polygon[i]}");
                Console.ReadLine();
            }
        }
    }
}
