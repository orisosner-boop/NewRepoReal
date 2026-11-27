using System;

namespace ShapesOopExercise
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC, ShapeColor color = ShapeColor.Green)
            : base(color)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override double GetArea()
        {
            double s = GetPerimeter() / 2.0;
            double insideSqrt = s * (s - SideA) * (s - SideB) * (s - SideC);
            return insideSqrt > 0 ? Math.Sqrt(insideSqrt) : 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Sides={SideA}, {SideB}, {SideC})";
        }
    }
}