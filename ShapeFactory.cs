using design_pattern_factory.Constans;
using design_pattern_factory.Implementations;
using design_pattern_factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shape)
        {
            switch (shape)
            {
                case CStrings.CIRCLE:
                    return new Circle();
                case CStrings.SQUARE:
                    return new Square();
                case CStrings.RECTANGLE:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
