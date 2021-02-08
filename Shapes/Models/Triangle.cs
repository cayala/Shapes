using Shapes.Models.Abstracts;
using Shapes.Models.Constants;
using Shapes.Models.Enums;
using Shapes.Models.Interfaces;
using System;

namespace Shapes.Models
{
    public class Triangle: Shape, IShapes
    {
        public double Base { get; }
        public double Height { get; }
        public TypeOfShape Type { get; }
        public TypeOfColor Color { get; }
        public Triangle(double triangleBase, double height, string color)
            => (Base, Height, Color, Type) = (triangleBase, height, GetColorType(color), TypeOfShape.Triangle);
        public override double CalculateArea()
            => Math.Round((Base * Height)/ 2, 2);
        public override string OutputShapeInformation()
            => Type + ShapeConstants.OutputSeparator + CalculateArea().ToString() + ShapeConstants.OutputSeparator + Color;
    }
}
