using design_pattern_factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_factory.Implementations
{
    public class Square : IShape
    {
        public void Area()
        {
            Console.WriteLine("Inside Square: Area() method.");
        }
    }
}
