using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeObjectOrientedDesign
{
    abstract class Shape
    {
        // ... 他の共通のプロパティやメソッド ...

        public abstract double CalculateArea();

    }

    class Circle : Shape
    {
        public Circle (double radius_)
        {
            Radius = radius_;
        }
        private double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Square : Shape
    {
        public Square(double side_length_)
        {
            SideLength = side_length_;
        }
        private double SideLength { get; set; }
        public override double CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

    class Triangle : Shape
    {
        public Triangle(double bottom_, double height_)
        {
            Bottom = bottom_;
            Height = height_;
        }
        private double Bottom { get; set; }
        private double Height { get; set; }

        public override double CalculateArea()
        {
            return Bottom * Height / 2;
        }
    }
}
