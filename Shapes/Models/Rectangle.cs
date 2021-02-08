using System;
using Shapes.Models.Abstracts;
using Shapes.Models.Constants;
using Shapes.Models.Enums;
using Shapes.Models.Interfaces;

namespace Shapes.Models
{
    public class Rectangle: Shape, IShapes
    {
        public double Length { get; }
        public double Width { get; }
        public TypeOfShape Type { get; }
        public TypeOfColor Color { get; }
        public Rectangle(double length, double width, string color)
            => (Length, Width, Color, Type) = (length, width, GetColorType(color), TypeOfShape.Rectangle);
        public override double CalculateArea()
            => Math.Round(Length * Width, 2);
        public override string OutputShapeInformation()
            => Type + ShapeConstants.OutputSeparator + CalculateArea().ToString() + ShapeConstants.OutputSeparator + Color;
    }
}
