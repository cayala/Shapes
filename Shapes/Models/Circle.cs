using Shapes.Models.Abstracts;
using Shapes.Models.Constants;
using Shapes.Models.Enums;
using Shapes.Models.Interfaces;
using System;

namespace Shapes.Models
{
    public class Circle: Shape, IShapes
    {
        public double Radius { get; }
        public TypeOfShape Type { get; }
        public TypeOfColor Color { get; }
        public Circle(double radius, string color)
            => (Radius, Color, Type) = (radius, GetColorType(color), TypeOfShape.Circle);
        public override double CalculateArea()
            => Math.Round(Math.PI * (Radius * Radius), 2);
        public override string OutputShapeInformation()
            => Type + ShapeConstants.OutputSeparator + CalculateArea().ToString() + ShapeConstants.OutputSeparator + Color;
    }
}
