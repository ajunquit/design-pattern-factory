using design_pattern_factory.Constans;
using design_pattern_factory.Implementations;
using design_pattern_factory.Interfaces;
using System;

namespace design_pattern_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape circle = shapeFactory.GetShape(CStrings.CIRCLE);
            circle.Area();

            IShape rectangle = shapeFactory.GetShape(CStrings.RECTANGLE);
            rectangle.Area();

            IShape square = shapeFactory.GetShape(CStrings.SQUARE);
            square.Area();
        }
    }
}
