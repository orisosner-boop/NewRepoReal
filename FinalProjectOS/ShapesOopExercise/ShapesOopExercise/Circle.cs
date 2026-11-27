using System;

namespace ShapesOopExercise
{
    public class Circle : Shape, IRollable
    {
        public double Radius { get; set; }

        public Circle(double radius, ShapeColor color = ShapeColor.Red)
            : base(color)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public string Roll()
        {
            return $"Circle (ID: {Id}, Color: {Color}) is rolling smoothly. Circumference per turn: {GetPerimeter():F2}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Radius={Radius})";
        }
    }
}