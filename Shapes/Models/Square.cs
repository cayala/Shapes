using System;
using Shapes.Models.Abstracts;
using Shapes.Models.Constants;
using Shapes.Models.Enums;
using Shapes.Models.Interfaces;

namespace Shapes.Models
{
    public class Square : Shape, IShapes
    {
        public double Length { get; }
        public TypeOfShape Type { get; }
        public TypeOfColor Color { get; }
        public Square(double length, string color)
        => (Length, Color, Type) = (length, GetColorType(color), TypeOfShape.Square);        
        public override double CalculateArea()
            => Math.Round(Length * Length, 2);
        public override string OutputShapeInformation()
            => Type + ShapeConstants.OutputSeparator + CalculateArea().ToString() + ShapeConstants.OutputSeparator + Color;
    }
}
