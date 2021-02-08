using Shapes.Models;
using Shapes.Models.Constants;
using Shapes.Models.Enums;
using Shapes.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFile = System.IO.File.ReadAllText(@"");
            string[] stringInput = textFile.Split(ShapeConstants.OutputSeparator);
            List<IShapes> shapes = GenerateListOfShapes(stringInput);

            WriteOutAllShapes();
            WriteOutAllTriangles();
            WriteOutAllPurpleShapes();
            EndProgram();

            static void WriteNewLine()
                => Console.WriteLine();
            static void EndProgram()
            {
                Console.WriteLine("Reached the end of the program. Press any key to exit");
                Console.ReadKey();
                Environment.Exit(0);
            }
            void WriteOutAllShapes()
            {
                Console.WriteLine("All shapes:");
                WriteNewLine();
                //Logic to output all shapes
                foreach (var shape in shapes.OrderBy(x => x.CalculateArea()).ThenBy(x => x.Color))
                {
                    Console.WriteLine(shape.OutputShapeInformation());
                }
                WriteNewLine();
            }
            void WriteOutAllTriangles()
            {
                Console.WriteLine("Triangles:");
                WriteNewLine();
                //Logic to output all triangles
                foreach (var shape in shapes.Where(x => x.Type == TypeOfShape.Triangle).OrderBy(x => x.CalculateArea()).ThenBy(x => x.Color))
                {
                    Console.WriteLine(shape.OutputShapeInformation());
                }
                WriteNewLine();
            }
            void WriteOutAllPurpleShapes()
            {
                Console.Write("Purple shapes:");
                WriteNewLine();
                foreach (var shape in shapes.Where(x => x.Color == TypeOfColor.Purple).OrderBy(x => x.CalculateArea()).ThenBy(x => x.Color))
                {
                    Console.WriteLine(shape.OutputShapeInformation());
                }
                WriteNewLine();
            }
            static List<IShapes> GenerateListOfShapes(string[] array)
            {
                var shapes = new List<IShapes>();
                for (int index = 0; index < array.Length; index++)
                {
                    try
                    {
                        if (array[index] == TypeOfShape.Square.ToString().ToLower())
                            shapes.Add(new Square(double.Parse(array[index + 1]), array[index + 2]));
                        else if (array[index] == TypeOfShape.Circle.ToString().ToLower())
                            shapes.Add(new Circle(double.Parse(array[index + 1]), array[index + 2]));
                        else if (array[index] == TypeOfShape.Rectangle.ToString().ToLower())
                            shapes.Add(new Rectangle(double.Parse(array[index + 1]), double.Parse(array[index + 2]), array[index + 3]));
                        else if (array[index] == TypeOfShape.Triangle.ToString().ToLower())
                            shapes.Add(new Triangle(double.Parse(array[index + 1]), double.Parse(array[index + 2]), array[index + 3]));
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"A shape was not loaded due to an input posiibly not being a number at shape index {index}");
                        WriteNewLine();
                        continue;
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine($"A shape was not loaded due to a possible missing input at shape index {index}");
                        WriteNewLine();
                        continue;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"A shape was not loaded due to an unhandled exception at index {index}");
                        WriteNewLine();
                        continue;
                    }
                }
                return shapes;
            }
        }
    }
}
