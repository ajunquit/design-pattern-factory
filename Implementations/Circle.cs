using design_pattern_factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_factory.Implementations
{
    public class Circle : IShape
    {
       
        public void Area()
        {
            Console.WriteLine("Inside Circle: Area() method.");
        }
    }
}
