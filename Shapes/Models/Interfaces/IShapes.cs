using Shapes.Models.Enums;

namespace Shapes.Models.Interfaces
{
    public interface IShapes
    {
        public TypeOfColor Color { get; }
        public TypeOfShape Type { get; }
        public double CalculateArea();
        public string OutputShapeInformation();
    }
}
