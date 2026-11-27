using System;
using System.Collections.Generic;

namespace ShapesOopExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Shape rect = new Rectangle(4, 6, ShapeColor.Blue);
            Shape circle = new Circle(5, ShapeColor.Red);
            Shape triangle = new Triangle(3, 4, 5, ShapeColor.Green);

            
            List<Shape> shapesList = new List<Shape>
            {
                rect,
                circle,
                triangle
            };

            Console.WriteLine("--- הדפסת כל הצורות מתוך List<Shape> ---");
            foreach (Shape shape in shapesList)
            {
                Console.WriteLine(shape.ToString());
            }

            Console.WriteLine();

           
            Console.WriteLine("--- הפעלת ממשק IRollable ---");
            foreach (Shape shape in shapesList)
            {
                if (shape is IRollable rollable)
                {
                    Console.WriteLine(rollable.Roll());
                }
            }

            Console.WriteLine();

            
            Dictionary<string, Shape> shapesDictionary = new Dictionary<string, Shape>();
            foreach (Shape shape in shapesList)
            {
                shapesDictionary[shape.Id] = shape;
            }

            Console.WriteLine("--- הדפסת הצורות מתוך Dictionary<string, Shape> ---");
            foreach (KeyValuePair<string, Shape> item in shapesDictionary)
            {
                Console.WriteLine($"Key [{item.Key}] => {item.Value}");
            }
        }
    }
}