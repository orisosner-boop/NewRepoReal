namespace ShapesOopExercise
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, ShapeColor color = ShapeColor.Blue)
            : base(color)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Width={Width}, Height={Height})";
        }
    }
}