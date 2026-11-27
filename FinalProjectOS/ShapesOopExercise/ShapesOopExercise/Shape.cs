namespace ShapesOopExercise
{
    public abstract class Shape
    {
        private static int _nextNumericId = 0;

        public string Id { get; }

        public ShapeColor Color { get; set; }

        protected Shape(ShapeColor color = ShapeColor.Black)
        {
            _nextNumericId++;
            Id = _nextNumericId.ToString("D9");
            Color = color;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"[{GetType().Name}] ID: {Id}, Color: {Color}, Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}";
        }
    }
}