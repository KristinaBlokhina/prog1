using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr.lab1._2_7_
{
    public class TCircle
    {
        protected double radius;
        public TCircle()
        {
            radius = 0;
        }
        public TCircle(double radius)
        {
            this.radius = radius;
        }
        public TCircle(TCircle other)
        {
            this.radius = other.radius;
        }
        public override string ToString()
        {
            return $"Circle with radius={radius}";
        }
        public void InputData()
        {
            Console.WriteLine("Enter radius:");
            radius =
                Convert.ToDouble(Console.ReadLine());
        }
        public void OutputData()
        {
            Console.WriteLine(ToString());
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculateSectorArea(double angle)
        {
            return 0.5 * radius * radius * angle;
        }
        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public bool Equals(TCircle other)
        {
            return this.radius == other.radius;
        }
        public static TCircle operator +(TCircle c1, TCircle c2)
        {
            return new TCircle(c1.radius + c2.radius);
        }

        public static TCircle operator -(TCircle c1, TCircle c2)
        {
            return new TCircle(Math.Abs(c1.radius - c2.radius));
        }
        public static TCircle operator *(double num, TCircle c)
        {
            return new TCircle(c.radius * num);
        }
        public static TCircle operator *(TCircle c, double num)
        {
            return new TCircle(c.radius * num);
        }
    }

    public class TCone : TCircle
    {
        private double height;
        public TCone() : base()
        {
            height = 0;
        }
        public TCone(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public TCone(TCone other) : base(other)
        {
            this.height = other.height;
        }
        public override string ToString()
        {
            return $"Cone with radius = {radius} and height = {height}";
        }
        public double CalculateVolume()
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;
        }
    }
}
