using System;
using Shapes.Models.Enums;

namespace Shapes.Models.Abstracts
{
    public abstract class Shape 
    {
        public abstract string OutputShapeInformation();
        public abstract double CalculateArea();
        protected TypeOfColor GetColorType(string color)
            => color.ToLower() switch 
            {
                "red" => TypeOfColor.Red,
                "blue" => TypeOfColor.Blue,
                "green" => TypeOfColor.Green,
                "yellow" => TypeOfColor.Yellow,
                "purple" => TypeOfColor.Purple,
                null => throw new ArgumentException("Error: null is not accepted for adding color to shape"),
                _ => throw new ArgumentException("Error: Color passed into shape is not accepted")
            };
    }
}
